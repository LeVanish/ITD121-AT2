using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// Handles adding a Point shape to the current drawing.
    /// </summary>
    class PointMenuItem : MenuItem
    {
        /// <summary>
        /// Creates a "Point" menu item associated with the current drawing.
        /// </summary>
        public PointMenuItem(string key, string title, List<Shape> shapes, Canvas canvas) : base(key, title)
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
        /// Prompts the user for point coordinates and character, then adds the point to the drawing.
        /// </summary>
        public override void Action()
        {
            Console.WriteLine();
            Console.WriteLine("Add point to drawing:");
            Console.WriteLine();

            int x;
            int y;
            char symbol;
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

            // Create the coordinate object so it can be passed to the Point constructor.
            Coordinates xy = new Coordinates(x, y);
            while (true)
            {

                Console.Write("Symbol: ");
                var s = Console.ReadLine();
                if (s != null && s != "")
                {
                    symbol = s[0];
                    if (symbol >= '!' && symbol <= '~')
                    {
                        break;
                    }
                }

                Console.WriteLine("Please supply a character between '!' and '~'");
            }

            Point p = new Point(xy, symbol);

            p.Draw(Canvas);

            AddItem(Shapes, p);
        }
    }
}
