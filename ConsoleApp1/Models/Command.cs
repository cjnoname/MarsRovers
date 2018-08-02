using ConsoleApp1.Interfaces;
using ConsoleApp1.Services;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Models
{
    public class Command
    {
        public Dictionary<char, IAction> Actions { get; set; }
        public List<char> CommandList { get; set; }

        public Command()
        {
            Actions = new Dictionary<char, IAction>
            {
                { 'M', new MoveAction() },
                { 'L', new TurnLeftAction() },
                { 'R', new TurnRightAction() }
            };
        }

        public void UpdateCommand(string command)
        {
            CommandList = command.ToCharArray().ToList();
        }
    } 
}
