using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// Represents a menu containing a collection of selectable menu items.
    /// </summary>
    class Menu : MenuItem
    {
        List<MenuItem> items = new List<MenuItem>();

        /// <summary>
        /// Creates a menu with the specified key and title.
        /// </summary>
        public Menu(string key, string title) : base(key, title)
        {
        }

        /// <summary>
        /// Adds a menu item to the menu.
        /// </summary>
        /// <param name="item">The menu item to add.</param>
        public void Add(MenuItem item)
        {
            items.Add(item);

        }

        /// <summary>
        /// Displays the menu and processes user selections until the menu is closed.
        /// </summary>
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
