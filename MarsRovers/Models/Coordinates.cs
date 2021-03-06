﻿using MarsRovers.Interfaces;

namespace MarsRovers.Models
{
    public class Coordinates : ICoordinates
    {
        public int XAxis { get; set; }
        public int YAxis { get; set; }

        public Coordinates()
        {
        }

        public Coordinates(int xAxis, int yAxis)
        {
            XAxis = xAxis;
            YAxis = yAxis;
        }

        public void UpdateCoordinates(int xAxis, int yAxis)
        {
            XAxis = xAxis;
            YAxis = yAxis;
        }

        public override string ToString() => $"{XAxis} {YAxis}";

        public (int newX, int newY) AfterOffset(int xAxisOffset, int yAixsOffset) => (xAxisOffset + XAxis, yAixsOffset + YAxis);
    }
}
