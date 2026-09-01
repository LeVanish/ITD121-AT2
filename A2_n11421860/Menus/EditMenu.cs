using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    class EditMenu : Menu
    {
        List<MenuItem> items = new List<MenuItem>();
        public EditMenu(string key, string title, List<Shape> shapes, Canvas canvas) : base(key, title)
        {
            items.Add(new PointMenuItem("Point", "Add point to drawing", shapes, canvas));
            items.Add(new LineMenuItem("Line", "Add line to drawing", shapes, canvas));
            items.Add(new TextMenuItem("Text", "Add text to drawing", shapes, canvas));
            items.Add(new PreviewMenuItem("Preview", "Preview drawing", shapes, canvas));
            items.Add(new ListMenuItem("List", "List elements in drawing", shapes));
            items.Add(new DeleteMenuItem("Delete", "Delete element from drawing", shapes, canvas));
            items.Add(new PointMenuItem("Return", "Return to previous menu", shapes, canvas));
        }

        public override void Action()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Editing drawing UnnamedDrawing.txt");
                Console.WriteLine();

                foreach (MenuItem item in items)
                {
                    Console.WriteLine($"{item.Key,-7} -> {item.Title}");
                }
                Console.Write("? ");

                var s = Console.ReadLine();

                if (s == null) break;

                s = s.Trim().ToLower();

                if (s == "close" || s == "return") break;

                bool found = false;

                foreach (var item in items)
                {
                    if (s == item.Key.ToLower())
                    {
                        found = true;
                        item.Action();
                        break;
                    }
                }
                if (!found) Console.WriteLine("\tInvalid option, please try again");

            }
        }
    }
}
