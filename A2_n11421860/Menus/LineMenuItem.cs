using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    class LineMenuItem : MenuItem
    {
        public LineMenuItem(string key, string title, List<Shape> shapes, Canvas canvas) : base(key, title)
        {
            this.Shapes = shapes;
            this.Canvas = canvas;
        }
        public List<Shape> Shapes { get; }
        public Canvas Canvas { get; }

        public override void Action()
        {
            Console.WriteLine();
            Console.WriteLine("Add line to drawing:");
            Console.WriteLine();

            int x1;
            int y1;
            int x2;
            int y2;
            char symbol;
            while (true)
            {
                Console.Write("Start X: ");
                var s = Console.ReadLine();
                if (int.TryParse(s, out x1))
                {
                    break;
                }
                Console.WriteLine("Please supply a whole number.");
            }

            while (true)
            {
                Console.Write("Start Y: ");
                var s = Console.ReadLine();
                if (int.TryParse(s, out y1))
                {
                    break;
                }
                Console.WriteLine("Please supply a whole number.");
            }

            while (true)
            {
                Console.Write("End X: ");
                var s = Console.ReadLine();
                if (int.TryParse(s, out x2))
                {
                    break;
                }
                Console.WriteLine("Please supply a whole number.");
            }

            while (true)
            {
                Console.Write("End Y: ");
                var s = Console.ReadLine();
                if (int.TryParse(s, out y2))
                {
                    break;
                }
                Console.WriteLine("Please supply a whole number.");
            }

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

            Line l = new Line(new Coordinates(x1, y1), new Coordinates(x2, y2), symbol);

            l.Draw(Canvas);

            AddItem(Shapes, l);
        }
    }
}
