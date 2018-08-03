namespace MarsRovers.Interfaces
{
    /// <summary>
    /// The coordinate properties and functions
    /// </summary>
    public interface ICoordinates
    {
        /// <summary>
        /// x axis value
        /// </summary>
        int XAxis { get; set; }

        /// <summary>
        ///y axis value
        /// </summary>
        int YAxis { get; set; }

        /// <summary>
        /// update current coordinates
        /// </summary>
        void UpdateCoordinates(int xAxis, int yAxis);

        /// <summary>
        /// Override the default ToString function to generate the coorinate output string
        /// </summary>
        string ToString();

        /// <summary>
        /// get values after offset
        /// </summary>
        (int newX, int newY) AfterOffset(int xAxisOffset, int yAixsOffset);
    }
}
