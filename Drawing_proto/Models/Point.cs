using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    public class Point : Shape
    {
        /// <summary>
        ///     Get the symbol used to display the point.
        /// </summary>
        public char Symbol { get; }

        /// <summary>
        ///     Initialis the Point.
        /// </summary>
        /// <param name="position">The position of the point.</param>
        /// <param name="symbol">The symbol used to display the point.</param>
        public Point(Coordinates position, char symbol) : base(position, width: 1, height: 1)
        {
            Symbol = symbol;
        }

        public override string ToString()
        {
            return $"{Position.X}\t{Position.Y}\t{Symbol}";
        }
        public override void Draw(Canvas canvas)
        {
            // Console.Error.WriteLine( $"Symbol {Symbol} drawn at {Position}" );
            canvas.Draw(Position.Y, Position.X, Symbol);
        }
    }
}
