using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A2_n11421860
{
    class PreviewMenuItem : MenuItem
    {
        public PreviewMenuItem(string key, string title, List<Shape> shapes, Canvas canvas) : base(key, title)
        {
            this.Shapes = shapes;
            this.Canvas = canvas;
        }
        public List<Shape> Shapes { get; }
        public Canvas Canvas { get; }

        public override void Action()
        {
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
