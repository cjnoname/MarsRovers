namespace ConsoleApp1.Models
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

        public Plateau(int maxXAxis, int maxYAxis, int minXAxis = 0, int minYAxis = 0)
        {
            MaxXAxis = maxXAxis;
            MaxYAxis = maxYAxis;
            MinXAxis = minXAxis;
            MinYAxis = minYAxis;
        }

        public bool InBound(Coordinates coordinates) =>
            coordinates.XAxis >= MinXAxis &&
            coordinates.XAxis <= MaxXAxis &&
            coordinates.YAxis >= MinYAxis &&
            coordinates.YAxis <= MaxYAxis;
    }
}
