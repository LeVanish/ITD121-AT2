using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace A2_n11421860
{
    class MenuItem
    {
        public string Key { get; }

        public string Title { get; }

        public MenuItem(string key, string title)
        {
            this.Key = key;
            this.Title = title;
        }

        public virtual void Action()
        {
            Console.WriteLine($"{Title} action has been invoked.");
        }


        public void AddItem(List<Shape> shapes, Shape shape)
        {
            if (shapes.Count == 0)
            {
                shapes.Add(shape);

            }
            else
            {
                bool retry = true;
                while (retry)
                {
                    Console.Write($"Position (0 .. {shapes.Count}, blank == after last element): ");
                    var s = Console.ReadLine();
                    if (s == null || s == "")
                    {
                        shapes.Add(shape);
                        break;
                    }
                    int pos;
                    if (int.TryParse(s, out pos))
                    {
                        if (pos <= shapes.Count)
                        {
                            shapes.Insert(pos, shape);
                            break;
                        }
                    }
                    Console.WriteLine($"Please supply a whole number between 0 and {shapes.Count}");
                }
            }
        }
    }
}
