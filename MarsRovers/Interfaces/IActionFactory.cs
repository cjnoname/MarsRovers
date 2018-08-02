using MarsRovers.Enums;

namespace MarsRovers.Interfaces
{
    public interface IActionFactory
    {
        IAction GetActionByType(ActionType actionType);
    }
}
