using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    public class MoveAction : BaseAction
    {
        public override void Action(MarsRover marsRover)
        {
            marsRover.Move();
        }
    }
}
