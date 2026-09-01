using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drawing_proto
{
    class ListMenuItem : MenuItem
    {
        public ListMenuItem(string key, string title, List<Shape> shapes) : base(key, title)
        {
            this.Shapes = shapes;
        }
        public List<Shape> Shapes { get; }
        public override void Action()
        {
            Console.WriteLine();
            Console.WriteLine("Drawing contains the following elements:");
            Console.WriteLine();
            Console.WriteLine("Shape");
            for (int i = 0; i < Shapes.Count; i++)
            {
                string shape_type = Shapes[i].GetType().Name;
                Console.WriteLine($"{shape_type}\t{Shapes[i].ToString()}");
            }
            Console.WriteLine("End Shape");
        }
    }
}
