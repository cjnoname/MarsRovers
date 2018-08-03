using MarsRovers.Enums;
using MarsRovers.Factories;
using MarsRovers.Interfaces;
using MarsRovers.Utils;
using System.Collections.Generic;

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
            Plateau = InputUtils.GeneratePlateauObject(plateauInput);
            Coordinates = new Coordinates();
            Direction = new Direction();
        }

        public void UpdateValues(string initialStateInput, string actionInput = "")
        {
            (int xAxis, int yAixs, DirectionType directionType) = InputUtils.GetInitialStateValues(initialStateInput);
            Coordinates.UpdateCoordinates(xAxis, yAixs);
            Direction.UpdateDirection(directionType);
            ActionList = InputUtils.GetActionList(actionInput);
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

    }
}
