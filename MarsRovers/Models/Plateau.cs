namespace MarsRovers.Models
{
    public class Plateau
    {
        public int MaxXAxis { get; set; }
        public int MaxYAxis { get; set; }
        public int MinXAxis { get; set; }
        public int MinYAxis { get; set; }

        public Plateau(string input)
        {
            var axises = input.Split(" ");
            MaxXAxis = int.Parse(axises[0]);
            MaxYAxis = int.Parse(axises[1]);
            MinXAxis = 0;
            MinYAxis = 0;
        }

        public Plateau(int maxXAxis, int maxYAxis)
        {
            MaxXAxis = maxXAxis;
            MaxYAxis = maxYAxis;
            MinXAxis = 0;
            MinYAxis = 0;
        }

        public bool InBound(int xAxis, int yAxis) =>
            xAxis >= MinXAxis &&
            xAxis <= MaxXAxis &&
            yAxis >= MinYAxis &&
            yAxis <= MaxYAxis;
    }
}
