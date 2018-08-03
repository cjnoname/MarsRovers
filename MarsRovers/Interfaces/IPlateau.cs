namespace MarsRovers.Interfaces
{
    /// <summary>
    /// The Plateau properties and functions
    /// </summary>
    public interface IPlateau
    {
        /// <summary>
        /// The min Y axis of Plateau
        /// </summary>
        int MaxXAxis { get; set; }

        /// <summary>
        /// The max Y axis of Plateau
        /// </summary>
        int MaxYAxis { get; set; }

        /// <summary>
        /// The min X axis of Plateau (is not used)
        /// </summary>
        int MinXAxis { get; set; }

        /// <summary>
        /// The min Y axis of Plateau (is not used)
        /// </summary>
        int MinYAxis { get; set; }

        /// <summary>
        /// The check whether this paticular coordinate is within the bound
        /// </summary>
        bool InBound(int xAxis, int yAxis);
    }
}
