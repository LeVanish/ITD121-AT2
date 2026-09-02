using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// The character-based drawing surface used by the application.
    /// </summary>
    public class Canvas
    {
        private int width;
        private int height;
        private char[,] cells;

        /// <summary>
        /// Get the width of the canvas.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown if atemted to set value to zero or lower.
        /// </exception>
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be greater than zero.");
                }

                width = value;
            }
        }

        /// <summary>
        /// Get the height of the canvas.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// ArgumentException is thrown if vlaue is not greater than zero.
        /// </exception>
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be greater than zero.");
                }

                height = value;
            }
        }

        /// <summary>
        /// Creates an empty canvas with the specified dimensions.
        /// </summary>
        /// <param name="width">The width of the canvas.</param>
        /// <param name="height">The height of the canvas.</param>
        public Canvas(int width = 80, int height = 28)
        {
            Width = width;
            Height = height;
            cells = new char[height, width];
            Clear();
        }

        /// <summary>
        /// Clear the canvas by replacing every cell with a space.
        /// </summary>
        public void Clear()
        {
            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    cells[row, col] = ' ';
                }
            }
        }

        /// <summary>
        /// Render the canvas in the console.
        /// </summary>
        public void Show()
        {
            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    Console.Write(cells[row, col]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Sets the contents of a cell to a given value.
        /// Coordinates out of bounds are ignored and canvas remains unchanged.
        /// </summary>
        /// <param name="row">Row of the cell to modify.</param>
        /// <param name="col">Column of the cell to modify.</param>
        /// <param name="c">The character to render in the designated call.</param>
        public void Draw(int row, int col, char c)
        {
            if (row < 0 || row >= Height || col < 0 || col >= Width) return;

            cells[row, col] = c;
        }

        /// <summary>
        /// Draws a line of text starting at the specified column and row.
        /// Characters falling out of bounds are ignored.
        /// </summary>
        /// <param name="col">The column at which the text starts.</param>
        /// <param name="row">The row at which the text starts.</param>
        /// <param name="s">The text to draw.</param>
        public void Draw(int col, int row, string s)
        {
            for (int i = 0; i < s.Length; i++)
                Draw(row, col + i, s[i]);
        }

        /// <summary>
        /// Swaps the values of two integer variables.
        /// </summary>
        /// <param name="a">First value.</param>
        /// <param name="b">Second value.</param>
        public static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        /// <summary>
        /// Draws a line between two points using the specified character.
        /// Points out of bounds are ignored.
        /// </summary>
        /// <param name="x0">The line start column.</param>
        /// <param name="y0">The line start row.</param>
        /// <param name="x1">The line end column.</param>
        /// <param name="y1">The line end row.</param>
        /// <param name="symbol">The character used to draw the line.</param>
        public void Draw(int x0, int y0, int x1, int y1, char symbol)
        {
            double dx = (x1 - x0);
            double dy = (y1 - y0);
            double adx = Math.Abs(x1 - x0);
            double ady = Math.Abs(y1 - y0);

            // Iterate along the axis with the larger change to determine the
            // corresponding coordinate on the other axis.
            if (adx >= ady)
            {
                if (x0 > x1)
                {
                    Swap(ref x0, ref x1);
                    Swap(ref y0, ref y1);
                    dx = -dx;
                    dy = -dy;
                }

                for (int x = x0; x <= x1; x++)
                {
                    double y = (x - x0) * dy / dx + y0;
                    Draw((int)Math.Round(y), x, symbol);
                }
            }
            else
            {
                if (y0 > y1)
                {
                    Swap(ref x0, ref x1);
                    Swap(ref y0, ref y1);
                    dx = -dx;
                    dy = -dy;
                }

                for (int y = y0; y <= y1; y++)
                {
                    double x = (y - y0) * dx / dy + x0;
                    Draw(y, (int)Math.Round(x), symbol);
                }

            }
        }
    }
}
