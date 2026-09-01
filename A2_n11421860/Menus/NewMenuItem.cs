using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A2_n11421860
{
    class NewMenuItem : MenuItem
    {
        public NewMenuItem(string key, string title, Canvas canvas, List<Shape> shapes) : base(key, title)
        {
            this.Canvas = canvas;
            this.Shapes = shapes;
        }
        public Canvas Canvas { get; }
        public List<Shape> Shapes { get; }

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
