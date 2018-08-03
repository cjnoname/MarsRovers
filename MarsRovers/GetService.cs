using MarsRovers.Interfaces;
using MarsRovers.Services;
using System;

namespace MarsRovers
{
    public sealed class GetService
    {
        private static readonly Lazy<IAction> _moveAction = new Lazy<IAction>(() => new MoveAction());
        private static readonly Lazy<IAction> _turnLeftAction = new Lazy<IAction>(() => new TurnLeftAction());
        private static readonly Lazy<IAction> _turnRightAction = new Lazy<IAction>(() => new TurnRightAction());

        public static IAction MoveAction
        {
            get
            {
                return _moveAction.Value;
            }
        }

        public static IAction TurnLeftAction
        {
            get
            {
                return _turnLeftAction.Value;
            }
        }

        public static IAction TurnRightAction
        {
            get
            {
                return _turnRightAction.Value;
            }
        }

    }
}
