using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drawing_proto
{
    /// <summary>
    /// Handles removing a shape from the current drawing.
    /// </summary>
    class DeleteMenuItem : MenuItem
    {
        /// <summary>
        /// Creates a "Delete" menu item associated with the current drawing.
        /// </summary>
        public DeleteMenuItem(string key, string title, List<Shape> shapes, Canvas canvas) : base(key, title)
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
        /// Prompts the user for a shape position, removes the selected shape, and re-renders the canvas.
        /// </summary>
        public override void Action()
        {
            Console.WriteLine();
            if (Shapes.Count == 0)
            {
                Console.WriteLine("\tDrawing contains no elements, selection ignored.");
                Console.WriteLine();
            }
            else
            {
                if (Shapes.Count == 1)
                {
                    Console.WriteLine($"The {Shapes[0].GetType().Name} element has been removed");
                    Shapes.RemoveAt(0);
                    Canvas.Clear();

                }
                else
                {
                    Console.WriteLine("Delete element from drawing:");
                    bool retry = true;
                    while (retry)
                    {
                        Console.WriteLine();
                        Console.Write($"Position (0 .. {Shapes.Count - 1}, blank == delete last element): ");
                        var s = Console.ReadLine();
                        if (s == null || s == "")
                        {
                            Shapes.RemoveAt(Shapes.Count - 1);
                            // Re-render the canvas because the removed shape may have occupied cells
                            // that are also affected by other shapes.
                            Canvas.Clear();
                            for (int i = 0; i < Shapes.Count; i++)
                            {
                                Shapes[i].Draw(Canvas);
                            }
                            break;
                        }
                        int pos;
                        if (int.TryParse(s, out pos))
                        {
                            if (pos <= Shapes.Count)
                            {
                                Shapes.RemoveAt(pos);
                                // Re-render the canvas so it represents the remaining shapes.
                                Canvas.Clear();
                                for (int i = 0; i < Shapes.Count; i++)
                                {
                                    Shapes[i].Draw(Canvas);
                                }
                                break;
                            }
                        }
                        Console.WriteLine($"Please supply a whole number between 0 and {Shapes.Count - 1}");
                    }
                }
            }
        }
    }
}
