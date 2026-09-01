using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    public class Line : Shape
    {
        /// <summary>
        ///     Get the symbol used to render the line.
        /// </summary>
        public char Symbol { get; }

        /// <summary>
        ///     Get the coordinates of the start of the line.
        ///     This is an alias for the inherited Position.
        /// </summary>
        public ICoordinates Start
        {
            get { return Position; }
        }

        /// <summary>
        ///     Get the coordinates of the end of the line.
        /// </summary>
        public ICoordinates End { get; }

        /// <summary>
        ///     Initialise the Line.
        /// </summary>
        /// <param name="start">The non-null start of the line.</param>
        /// <param name="end">The non-null end of the line.</param>
        /// <param name="symbol">The symbol used to render the line.</param>
        public Line(ICoordinates start, ICoordinates end, char symbol) :
            base(start, end.X - start.X + 1, end.Y - start.Y + 1)
        {
            End = end;
            Symbol = symbol;
        }

        /// <summary>
        ///     Gets the "height" of the line.
        ///     This may vary as both position and end are mutable.
        /// </summary>
        public override int Height
        {
            get
            {
                return End.Y - Start.Y + 1;
            }
        }

        /// <summary>
        ///     Get the "width" of the line.
        ///     This may vary as both position and end are mutable.
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
        ///     Renders the line into the Canvas.
        /// </summary>
        /// <param name="canvas">
        ///     The non-null canvas to which the shape will be added.
        /// </param>
        public override void Draw(Canvas canvas)
        {
            canvas.Draw(Start.X, Start.Y, End.X, End.Y, Symbol);
        }
    }
}
