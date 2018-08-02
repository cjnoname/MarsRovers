using MarsRovers.Interfaces;
using MarsRovers.Models;

namespace MarsRovers.Services
{
    public abstract class BaseAction : IAction
    {
        public abstract void Action(MarsRover marsRover);
    }
}
