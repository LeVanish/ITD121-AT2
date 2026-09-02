using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// Represents a sequence of characters positioned on the canvas.
    /// </summary>
    public class Text : Shape
    {
        /// <summary>
        /// Gets the text displayed when this shape.
        /// </summary>
        public string Sentence { get; }

        /// <summary>
        /// Creates a text shape starting at the specified position.
        /// </summary>
        /// <param name="start">The starting position of the text.</param>
        /// <param name="text">The text to display.</param>
        public Text(Coordinates start, string text)
            : base(start, text.Length, 1)
        {
            Sentence = text;
        }

        public override string ToString()
        {
            return $"{Position.X}\t{Position.Y}\t{Sentence}" ;
        }

        /// <summary>
        /// Renders the text onto the canvas.
        /// </summary>
        /// <param name="canvas">The canvas to which the text is rendered.</param>
        public override void Draw(Canvas canvas)
        {
            canvas.Draw(Position.X, Position.Y, Sentence);
        }
    }
}
