using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// Class to represent a point int the canvas.
    /// </summary>
    public class Coordinates : ICoordinates
    {
        /// <summary>
        /// The horizontal position of the point.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// The vertical position of the point.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Set the initial location of the point.
        /// </summary>
        /// <param name="x">The initial horizontal location of the point.</param>
        /// <param name="y">The initial vertical location of the point.</param>
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Gets the coordinates as a string.
        /// </summary>
        /// <returns>Returns a string containing the coordinates.</returns>
        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}