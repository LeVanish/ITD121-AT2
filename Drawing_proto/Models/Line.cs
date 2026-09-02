using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// Represents a line between two coordinates on the canvas.
    /// </summary>
    public class Line : Shape
    {
        /// <summary>
        /// Get the character used to render the line.
        /// </summary>
        public char Symbol { get; }

        /// <summary>
        /// Gets the starting coordinates of the line.
        /// This is an alias for the inherited Position.
        /// </summary>
        public ICoordinates Start
        {
            get { return Position; }
        }

        /// <summary>
        /// Gets the ending coordinates of the line.
        /// </summary>
        public ICoordinates End { get; }

        /// <summary>
        /// Creates a line between the specified start and end coordinates.
        /// </summary>
        /// <param name="start">The start of the line.</param>
        /// <param name="end">The end of the line.</param>
        /// <param name="symbol">The character used to render the line.</param>
        public Line(ICoordinates start, ICoordinates end, char symbol) :
            base(start, end.X - start.X + 1, end.Y - start.Y + 1)
        {
            End = end;
            Symbol = symbol;
        }

        /// <summary>
        /// Gets the "height" of the line based on specified start and end coordinates.
        /// </summary>
        public override int Height
        {
            get
            {
                return End.Y - Start.Y + 1;
            }
        }

        /// <summary>
        /// Gets the "width" of the line based on specified start and end coordinates.
        /// </summary>
        public override int Width
        {
            get { return End.X - Start.X + 1; }
        }

        public override string ToString()
        {
            return $"{Start.X}\t{Start.Y}\t{End.X}\t{End.Y}\t{Symbol}";
        }

        /// <summary>
        /// Renders the line into the Canvas.
        /// </summary>
        /// <param name="canvas">The canvas onto which the line is rendered.</param>
        public override void Draw(Canvas canvas)
        {
            canvas.Draw(Start.X, Start.Y, End.X, End.Y, Symbol);
        }
    }
}
