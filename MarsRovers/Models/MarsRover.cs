using MarsRovers.Services;
using System.Collections.Generic;
using System.Linq;

namespace MarsRovers.Models
{
    public class MarsRover
    {
        public Coordinates Coordinates { get; set; }
        public Plateau Plateau { get; set; }
        public Direction Direction { get; set; }
        public List<char> CommandList { get; set; }

        public MarsRover(string plateauInput)
        {
            Plateau = new Plateau(plateauInput);
            Coordinates = new Coordinates();
            Direction = new Direction();
        }

        public void UpdateValues(string initialStateInput, string commandLineInput)
        {
            var initialStates = initialStateInput.Split(" ");
            Coordinates.UpdateCoordinates(int.Parse(initialStates[0]), int.Parse(initialStates[1]));
            Direction.UpdateDirection(initialStates[2]);
            CommandList = commandLineInput.ToCharArray().ToList();
        }

        public string RunAndGetResult(ActionFactory actionFactory)
        {
            CommandList.ForEach(command =>
            {
                actionFactory.GetActionByType(command).Action(this);
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
