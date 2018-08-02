﻿using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MarsRover marsRover = null;
            var actionFactory = new ActionFactory();

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
                    Console.WriteLine(marsRover.RunAndGetResult(actionFactory));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Run failed, please try again. Error: {e.Message}");
                }
            }
        }
    }
}
