using MarsRovers.Models;

namespace MarsRovers.Services
{
    public class MoveAction : BaseAction
    {
        public override void Action(MarsRover marsRover)
        {
            marsRover.Move();
        }
    }
}
