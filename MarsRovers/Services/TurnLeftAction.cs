using MarsRovers.Models;

namespace MarsRovers.Services
{
    public class TurnLeftAction : BaseAction
    {
        public override void Action(MarsRover marsRover)
        {
            marsRover.TurnLeft();
        }
    }
}
