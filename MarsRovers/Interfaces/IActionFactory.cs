namespace MarsRovers.Interfaces
{
    public interface IActionFactory
    {
        IAction GetActionByType(char actionType);
    }
}
