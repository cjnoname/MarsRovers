using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var marsRover = new MarsRover(Console.ReadLine());

            while (true)
            {
                marsRover.UpdateValues(Console.ReadLine(), Console.ReadLine());
                Console.WriteLine(marsRover.Run());
            }
        }
    }
}
