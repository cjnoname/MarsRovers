using ConsoleApp1.Enums;
using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var plateau = new Plateau(Console.ReadLine());

            string initialStateInput = null;
            string commandLineInput = null;
            string[] initialStates = null;
            while (true)
            {
                initialStateInput = Console.ReadLine();
                commandLineInput = Console.ReadLine();
                initialStates = initialStateInput.Split(" ");
                Enum.TryParse(initialStates[2], out DirectionType direction);

                var marsRover = new MarsRover
                {
                    Plateau = plateau,
                    Coordinates = new Coordinates(int.Parse(initialStates[0]), int.Parse(initialStates[1])),
                    Direction = new Direction(direction),
                    Command = new Command(commandLineInput)
                };

                var res = marsRover.Run();

                Console.WriteLine(res);
            }
        }
    }
}
