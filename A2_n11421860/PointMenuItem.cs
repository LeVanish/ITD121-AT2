using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace A2_n11421860
{
    class PointMenuItem : MenuItem
    {

        public PointMenuItem(string key, string title, List<Shape> shapes, Canvas canvas) : base(key, title)
        {
            this.Shapes = shapes;
            this.Canvas = canvas;
        }
        public List<Shape> Shapes { get; }
        public Canvas Canvas { get; }

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
