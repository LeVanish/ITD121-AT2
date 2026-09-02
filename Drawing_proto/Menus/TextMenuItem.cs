using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drawing_proto
{
    /// <summary>
    /// Handles adding Text shape to the current drawing.
    /// </summary>
    class TextMenuItem : MenuItem
    {
        /// <summary>
        /// Creates a "Text" menu item associated with the current drawing.
        /// </summary>
        public TextMenuItem(string key, string title, List<Shape> shapes, Canvas canvas) : base(key, title)
        {
            this.Shapes = shapes;
            this.Canvas = canvas;
        }

        /// <summary>
        /// Gets the canvas used by the current drawing.
        /// </summary>
        public Canvas Canvas { get; }

        /// <summary>
        /// Gets the collection of the current drawing's shapes.
        /// </summary>
        public List<Shape> Shapes { get; }

        /// <summary>
        /// Prompts the user for a starting position and text, then adds it to the drawing.
        /// </summary>
        public override void Action()
        {
            Console.WriteLine();
            Console.WriteLine("Add text to drawing:");
            Console.WriteLine();

            int x;
            int y;
            string text;

            while (true)
            {
                Console.Write("X: ");
                var s = Console.ReadLine();
                if (int.TryParse(s, out x))
                {
                    break;
                }
                Console.WriteLine("Please supply a whole number.");
            }

            while (true)
            {
                Console.Write("Y: ");
                var s = Console.ReadLine();
                if (int.TryParse(s, out y))
                {
                    break;
                }
                Console.WriteLine("Please supply a whole number.");
            }


            while (true)
            {
                Console.Write("Text: ");
                var s = Console.ReadLine();
                if (s != null && s != "")
                {
                    text = s;
                    break;
                }
                Console.Write("Please supply text");
            }

            // Create the Text shape using the supplied position and text.
            Text t = new Text(new Coordinates(x, y), text);

            t.Draw(Canvas);

            AddItem(Shapes, t);
        }
    }
}
