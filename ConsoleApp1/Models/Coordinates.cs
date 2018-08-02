namespace ConsoleApp1.Models
{
    public class Coordinates
    {
        public int XAxis { get; set; }
        public int YAxis { get; set; }

        public Coordinates()
        {
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
