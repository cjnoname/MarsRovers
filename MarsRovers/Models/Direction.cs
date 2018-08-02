using MarsRovers.Enums;
using System;

namespace MarsRovers.Models
{
    public class Direction
    {
        public DirectionType CurrentDirection { get; set; }

        public Direction()
        {
        }

        public Direction(DirectionType direction)
        {
            CurrentDirection = direction;
        }

        public void UpdateDirection(string currentDirection)
        {
            Enum.TryParse(currentDirection, out DirectionType direction);
            CurrentDirection = direction;
        }

        public override string ToString() => Enum.GetName(typeof(DirectionType), CurrentDirection);

        public (int xAxisOffset, int yAxisOffset) GetOffset()
        {
            switch (CurrentDirection)
            {
                case DirectionType.N:
                    return (0, 1);
                case DirectionType.S:
                    return (0, -1);
                case DirectionType.W:
                    return (-1, 0);
                case DirectionType.E:
                    return (1, 0);
                default:
                    return (0, 0);
            }
        }

        public void TurnLeft()
        {
            switch (CurrentDirection)
            {
                case DirectionType.N:
                    CurrentDirection = DirectionType.W;
                    break;
                case DirectionType.S:
                    CurrentDirection = DirectionType.E;
                    break;
                case DirectionType.W:
                    CurrentDirection = DirectionType.S;
                    break;
                case DirectionType.E:
                    CurrentDirection = DirectionType.N;
                    break;
            }
        }

        public void TurnRight()
        {
            switch (CurrentDirection)
            {
                case DirectionType.N:
                    CurrentDirection = DirectionType.E;
                    break;
                case DirectionType.S:
                    CurrentDirection = DirectionType.W;
                    break;
                case DirectionType.W:
                    CurrentDirection = DirectionType.N;
                    break;
                case DirectionType.E:
                    CurrentDirection = DirectionType.S;
                    break;
            }
        }
    }
}
