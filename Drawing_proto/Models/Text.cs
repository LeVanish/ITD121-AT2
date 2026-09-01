using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    public class Text : Shape
    {
        /// <summary>
        /// Gets the text displayed when this object is rendered.
        /// </summary>
        public string Sentence { get; }

        /// <summary>
        /// Initialise the Label.
        /// </summary>
        /// <param name="start">
        /// The position at which the beginning of the string is drawn.
        /// </param>
        /// <param name="text">
        /// The text to display.
        /// </param>
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
        /// Adds the text to the canvas.
        /// </summary>
        /// <param name="canvas">
        /// The non-null canvas object that will display the text.
        /// </param>
        public override void Draw(Canvas canvas)
        {
            canvas.Draw(Position.X, Position.Y, Sentence);
        }
    }
}
