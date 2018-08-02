using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    public class TurnRightAction : BaseAction
    {
        public override void Action(MarsRover marsRover)
        {
            marsRover.TurnRight();
        }
    }
}
