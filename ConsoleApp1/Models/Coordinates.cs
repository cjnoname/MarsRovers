namespace ConsoleApp1.Models
{
    public class Coordinates
    {
        public int XAxis { get; set; }
        public int YAxis { get; set; }

        public Coordinates(int xAxis, int yAxis)
        {
            XAxis = xAxis;
            YAxis = yAxis;
        }

        public override string ToString() => $"{XAxis} {YAxis}";

        public Coordinates AfterOffset(int xAxisOffset, int yAixsOffset) =>
            new Coordinates(xAxisOffset + XAxis, yAixsOffset + YAxis);

        public bool InBound(Plateau plateau) =>
                XAxis >= plateau.MinXAxis &&
                XAxis <= plateau.MaxXAxis &&
                YAxis >= plateau.MinYAxis &&
                YAxis <= plateau.MaxYAxis;
    }
}
