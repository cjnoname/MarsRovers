using MarsRovers.Enums;

namespace MarsRovers.Interfaces
{
    /// <summary>
    /// The direction properties and functions
    /// </summary>
    public interface IDirection
    {
        /// <summary>
        /// The value of current direction
        /// </summary>
        DirectionType CurrentDirection { get; set; }

        /// <summary>
        /// Change the currect direction
        /// </summary>
        void UpdateDirection(string currentDirection);

        /// <summary>
        /// Override the default ToString function to generate the direction output string
        /// </summary>
        string ToString();

        /// <summary>
        /// Get the moving offset value for the current direction
        /// </summary>
        /// <returns>
        /// The tuple of x and y moving offset value for current direction
        /// </returns>
        (int xAxisOffset, int yAxisOffset) GetOffset();

        /// <summary>
        /// Change the direction to the left
        /// </summary>
        void TurnLeft();

        /// <summary>
        /// Change the direction to the right
        /// </summary>
        void TurnRight();
    }
}
