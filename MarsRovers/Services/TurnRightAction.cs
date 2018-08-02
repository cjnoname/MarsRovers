using MarsRovers.Models;

namespace MarsRovers.Services
{
    public class TurnRightAction : BaseAction
    {
        public override void Action(MarsRover marsRover)
        {
            marsRover.TurnRight();
        }
    }
}
