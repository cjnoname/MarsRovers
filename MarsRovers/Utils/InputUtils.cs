using MarsRovers.Enums;
using MarsRovers.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRovers.Utils
{
    public static class InputUtils
    {
        public static Plateau GeneratePlateauObject(string input)
        {
            var axises = input.Split(" ");
            return new Plateau(int.Parse(axises[0]), int.Parse(axises[1]));
        }

        public static List<ActionType> GetActionList(string input) =>
            input.ToCharArray().Select(x =>
            {
                Enum.TryParse(x.ToString(), out ActionType actionType);
                return actionType;
            }).ToList();

        public static (int xAxis, int yAixs, DirectionType directionType) GetInitialStateValues(string input)
        {
            var initialStates = input.Split(" ");
            Enum.TryParse(initialStates[2], out DirectionType direction);
            return (int.Parse(initialStates[0]), int.Parse(initialStates[1]), direction);
        }
    }
}
