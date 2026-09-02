using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drawing_proto
{
    /// <summary>
    /// Handles creating a new drawing and discarding the current drawing when necessary.
    /// </summary>
    class NewMenuItem : MenuItem
    {
        /// <summary>
        /// Creates a "New" menu item associated with the current canvas and shape collection.
        /// </summary>
        public NewMenuItem(string key, string title, Canvas canvas, List<Shape> shapes) : base(key, title)
        {
            this.Canvas = canvas;
            this.Shapes = shapes;
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
        /// Creates a new empty drawing, asking for confirmation before discarding existing shapes.
        /// </summary>
        public override void Action()
        {

            if (Shapes.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Edits have been made to the current drawing.");
                Console.WriteLine();

                Console.WriteLine("Do you want to discard them?");
                Console.WriteLine();
                Console.WriteLine("Yes -> Discard changes");
                Console.WriteLine("No  -> Cancel");
                Console.Write("? ");

                var s = Console.ReadLine();
                if (s != null && s != "")
                {
                    string input = s.ToLower();
                    if (input == "yes")
                    {
                        Canvas.Clear();
                        Shapes.Clear();
                        Console.WriteLine("\tDrawing successfully created!");
                    }
                    else if (input == "no")
                    {
                        Console.WriteLine("\tOperation cancelled.");
                    }
                }
            }
            else Console.WriteLine("\tDrawing successfully created!");
        }
    }
}
