using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// Represents an action that can be selected from a menu.
    /// Derived menu items can override <see cref="Action"/> to provide specific behaviour.
    /// </summary>
    class MenuItem
    {
        /// <summary>
        /// Gets this menu item keyword.
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// Gets this menu item description.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Creates a menu item with the specified key and title.
        /// </summary>
        /// <param name="key">The keyword for selecting the item.</param>
        /// <param name="title">The description for the item.</param>
        public MenuItem(string key, string title)
        {
            this.Key = key;
            this.Title = title;
        }

        /// <summary>
        /// Executes the action represented by this menu item.
        /// </summary>
        public virtual void Action()
        {
            Console.WriteLine($"{Title} action has been invoked.");
        }

        /// <summary>
        /// Adds a shape to the collection at a user-selected position.
        /// A blank position adds the shape after the last existing element.
        /// </summary>
        /// <param name="shapes">The collection of shapes to modify.</param>
        /// <param name="shape">The shape to add.</param>
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
                    // Allow the user to control the order in which shapes are stored.
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
