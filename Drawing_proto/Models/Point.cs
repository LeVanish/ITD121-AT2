using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// Represents a single character positioned on the canvas.
    /// </summary>
    public class Point : Shape
    {
        /// <summary>
        /// Gets the character used to display the point.
        /// </summary>
        public char Symbol { get; }

        /// <summary>
        /// Creates a point at the specified position.
        /// </summary>
        /// <param name="position">The position of the point.</param>
        /// <param name="symbol">The character used to display the point.</param>
        public Point(Coordinates position, char symbol) : base(position, width: 1, height: 1)
        {
            Symbol = symbol;
        }

        public override string ToString()
        {
            return $"{Position.X}\t{Position.Y}\t{Symbol}";
        }

        /// <summary>
        /// Renders the point onto the canvas.
        /// </summary>
        /// <param name="canvas">The canvas to which the point is rendered.</param>
        public override void Draw(Canvas canvas)
        {
            canvas.Draw(Position.Y, Position.X, Symbol);
        }
    }
}
