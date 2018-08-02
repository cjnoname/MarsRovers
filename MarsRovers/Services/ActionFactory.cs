using MarsRovers.Enums;
using MarsRovers.Interfaces;

namespace MarsRovers.Services
{
    public class ActionFactory : IActionFactory
    {
        public IAction MoveAction { get; set; }
        public IAction TurnLeftAction { get; set; }
        public IAction TurnRightAction { get; set; }

        public ActionFactory()
        {
            MoveAction = new MoveAction();
            TurnLeftAction = new TurnLeftAction();
            TurnRightAction = new TurnRightAction();
        }

        public IAction GetActionByType(ActionType actionType)
        {
            switch (actionType)
            {
                case ActionType.M:
                    return MoveAction;
                case ActionType.L:
                    return TurnLeftAction;
                case ActionType.R:
                    return TurnRightAction;
                default:
                    return null;
            }
        }
    }
}
