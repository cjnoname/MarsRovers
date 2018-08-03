using MarsRovers.Enums;
using MarsRovers.Factories;
using MarsRovers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRovers.Models
{
    public class MarsRover : IMarsRover
    {
        public Coordinates Coordinates { get; set; }
        public Plateau Plateau { get; set; }
        public Direction Direction { get; set; }
        public List<ActionType> ActionList { get; set; }

        public MarsRover(string plateauInput)
        {
            Plateau = new Plateau(plateauInput);
            Coordinates = new Coordinates();
            Direction = new Direction();
        }

        public void UpdateValues(string initialStateInput, string actionInput = "")
        {
            var initialStates = initialStateInput.Split(" ");
            Coordinates.UpdateCoordinates(int.Parse(initialStates[0]), int.Parse(initialStates[1]));
            Direction.UpdateDirection(initialStates[2]);
            ActionList = GetActionList(actionInput);
        }

        public string RunAndGetResult()
        {
            ActionList.ForEach(actionType =>
            {
                ActionFactory.GetActionByType(actionType).Action(this);
            });
            return $"{Coordinates} {Direction}";
        }

        public void Move()
        {
            (int xAxisOffset, int yAxisOffset) = Direction.GetOffset();
            (int newX, int newY) = Coordinates.AfterOffset(xAxisOffset, yAxisOffset);

            // won't move if it's gonna to move out of bound
            if (Plateau.InBound(newX, newY))
            {
                Coordinates.UpdateCoordinates(newX, newY);
            }
        }

        public void TurnLeft() => Direction.TurnLeft();

        public void TurnRight() => Direction.TurnRight();

        private List<ActionType> GetActionList(string actionInput)
        {
            return actionInput.ToCharArray().Select(x =>
            {
                Enum.TryParse(x.ToString(), out ActionType actionType);
                return actionType;
            }).ToList();
        }
    }
}
