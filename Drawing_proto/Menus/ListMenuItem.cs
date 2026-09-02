using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drawing_proto
{
    /// <summary>
    /// Handles displaying the current drawing's shapes.
    /// </summary>
    class ListMenuItem : MenuItem
    {
        /// <summary>
        /// Creates a "List" menu item associated with the current shape collection.
        /// </summary>
        public ListMenuItem(string key, string title, List<Shape> shapes) : base(key, title)
        {
            this.Shapes = shapes;
        }

        /// <summary>
        /// Gets the collection of shapes to display.
        /// </summary>
        public List<Shape> Shapes { get; }

        /// <summary>
        /// Displays each shape and its position/data in the order it appears in the drawing.
        /// </summary>
        public override void Action()
        {
            Console.WriteLine();
            Console.WriteLine("Drawing contains the following elements:");
            Console.WriteLine();
            Console.WriteLine("Shape");
            for (int i = 0; i < Shapes.Count; i++)
            {
                // Use the runtime type so the list identifies whether each element is a Point, Line, or Text.
                string shape_type = Shapes[i].GetType().Name;
                Console.WriteLine($"{shape_type}\t{Shapes[i].ToString()}");
            }
            Console.WriteLine("End Shape");
        }
    }
}
