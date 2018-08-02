namespace ConsoleApp1.Models
{
    public class MarsRover
    {
        public Coordinates Coordinates { get; set; }
        public Plateau Plateau { get; set; }
        public Direction Direction { get; set; }
        public Command Command { get; set; }

        public MarsRover()
        {

        }

        public MarsRover(Coordinates coordinates, Plateau plateau, Direction direction)
        {
            Coordinates = coordinates;
            Plateau = plateau;
            Direction = direction;
        }

        public string Run()
        {
            Command.CommandList.ForEach(command =>
            {
                Command.Actions[command].Action(this);
            });
            return GetCurrentPosition();
        }

        public string GetCurrentPosition() => $"{Coordinates} {Direction}";

        public void Move()
        {
            (int xAxisOffset, int yAxisOffset) = Direction.GetOffset();
            var newCoordinates = Coordinates.AfterOffset(xAxisOffset, yAxisOffset);
            if (newCoordinates.InBound(Plateau))
            {
                Coordinates = newCoordinates;
            }
        }

        public void TurnLeft() => Direction.TurnLeft();

        public void TurnRight() => Direction.TurnRight();
    }
}
