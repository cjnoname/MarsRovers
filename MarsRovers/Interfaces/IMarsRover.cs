using MarsRovers.Enums;
using MarsRovers.Factories;
using MarsRovers.Models;
using System.Collections.Generic;

namespace MarsRovers.Interfaces
{
    /// <summary>
    /// The MarsRover properties and functions
    /// </summary>
    public interface IMarsRover
    {
        /// <summary>
        /// The coordinate of the current MarsRover
        /// </summary>
        Coordinates Coordinates { get; set; }

        /// <summary>
        /// The plateau of the current MarsRover
        /// </summary>
        Plateau Plateau { get; set; }

        /// <summary>
        /// The direction of the current MarsRover
        /// </summary>
        Direction Direction { get; set; }

        /// <summary>
        /// The action list of the current MarsRover
        /// </summary>
        List<ActionType> ActionList { get; set; }

        /// <summary>
        /// The update the values for current MarsRover
        /// </summary>
        void UpdateValues(string initialStateInput, string actionInput = "");

        /// <summary>
        /// The action factory of the current MarsRover
        /// </summary>
        string RunAndGetResult();

        /// <summary>
        /// The move action for MarsRover
        /// </summary>
        void Move();

        /// <summary>
        /// The turn left action for MarsRover
        /// </summary>
        void TurnLeft();

        /// <summary>
        /// The turn right action for MarsRover
        /// </summary>
        void TurnRight();
    }
}
