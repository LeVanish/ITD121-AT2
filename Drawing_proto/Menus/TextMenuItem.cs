using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drawing_proto
{
    class TextMenuItem : MenuItem
    {
        public TextMenuItem(string key, string title, List<Shape> shapes, Canvas canvas) : base(key, title)
        {
            this.Shapes = shapes;
            this.Canvas = canvas;
        }
        public List<Shape> Shapes { get; }
        public Canvas Canvas { get; }
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

            Text t = new Text(new Coordinates(x, y), text);

            t.Draw(Canvas);

            AddItem(Shapes, t);
        }
    }
}
