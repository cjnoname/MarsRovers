using MarsRovers.Enums;
using MarsRovers.Interfaces;

namespace MarsRovers.Factories
{
    public static class ActionFactory
    {
        public static IAction GetActionByType(ActionType actionType)
        {
            switch (actionType)
            {
                case ActionType.M:
                    return GetService.MoveAction;
                case ActionType.L:
                    return GetService.TurnLeftAction;
                case ActionType.R:
                    return GetService.TurnRightAction;
                default:
                    return null;
            }
        }
    }
}
