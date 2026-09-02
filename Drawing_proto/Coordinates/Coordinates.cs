using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// Class to represent a point on the canvas.
    /// </summary>
    public class Coordinates : ICoordinates
    {
        /// <summary>
        /// Gets or sets the horizontal coordinate.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the vertical coordinate.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Creates a coordinate with the specified horizontal and vertical values.
        /// </summary>
        /// <param name="x">The horizontal coordinate.</param>
        /// <param name="y">The vertical coordinate.</param>
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Returns the coordinates in the form <c>(X,Y)</c>.
        /// </summary>
        /// <returns>A string representation of the coordinates.</returns>
        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}