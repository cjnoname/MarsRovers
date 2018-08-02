using MarsRovers.Models;
using System;

namespace MarsRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            MarsRover marsRover = null;

            while (marsRover == null)
            {
                try
                {
                    marsRover = new MarsRover(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Plateau input is not valid, please try again. Error: {e.Message}");
                }
            }

            while (true)
            {
                try
                {
                    marsRover.UpdateValues(Console.ReadLine(), Console.ReadLine());
                    Console.WriteLine(marsRover.RunAndGetResult());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Run failed, please try again. Error: {e.Message}");
                }
            }
        }
    }
}
