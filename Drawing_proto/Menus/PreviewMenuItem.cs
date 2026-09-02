using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drawing_proto
{
    /// <summary>
    /// Handles displaying the current drawing on the canvas.
    /// </summary>
    class PreviewMenuItem : MenuItem
    {
        /// <summary>
        /// Creates a "Preview" menu item associated with the current drawing.
        /// </summary>
        public PreviewMenuItem(string key, string title, List<Shape> shapes, Canvas canvas) : base(key, title)
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
        /// Clears the canvas, re-renders every shape, and displays the drawing.
        /// </summary>
        public override void Action()
        {
            // Re-renders the canvas from the shapes collection so the drawing is accurate.
            Canvas.Clear();
            for (int i = 0; i < Shapes.Count; i++)
            {
                Shapes[i].Draw(Canvas);
            }
            Canvas.Show();
            Console.WriteLine("Press enter to continue ...                                                   ");
            Console.ReadLine();
        }
    }
}
