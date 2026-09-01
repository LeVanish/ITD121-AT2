using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    class Menu : MenuItem
    {
        List<MenuItem> items = new List<MenuItem>();

        public Menu(string key, string title) : base(key, title)
        {
        }

        public void Add(MenuItem item)
        {
            items.Add(item);

        }


        public override void Action()
        {

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"{Title} - please select an option");
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

                if (!found) Console.WriteLine("\tInvalid option, try again");
            }
        }

    }
}
