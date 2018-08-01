using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    public abstract class BaseAction : IAction
    {
        public abstract void Action(MarsRover marsRover);
    }
}
