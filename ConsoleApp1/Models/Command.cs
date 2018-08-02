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

        public Command(string command)
        {
            Actions = new Dictionary<char, IAction>
            {
                { 'M', new MoveAction() },
                { 'L', new TurnLeftAction() },
                { 'R', new TurnRightAction() }
            };
            CommandList = command.ToCharArray().ToList();
        }

        public void UpgradeCommand(string command)
        {
            CommandList = GetCommandList(command);
        }

        public List<char> GetCommandList(string command) => command.ToCharArray().ToList();
    } 
}
