using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    public class Canvas
    {
        private int width;
        private int height;
        private char[,] cells;

        /// <summary>
        /// Get the width of the canvas.
        /// </summary>
        /// <value>
        /// The (strictly positive) width of the canvas.
        /// </value>
        /// <exception cref="ArgumentException">
        /// ArgumentException is thrown if vlaue is not greater than zero.
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
        /// <value>
        /// The (strictly positive) width of the canvas.
        /// </value>
        /// <exception cref="ArgumentException">
        /// ArgumentException is thrown if vlaue is not greater than zero.
        /// </exception>
        public int Height
        {
            get
            {
                return height;
            }
            private set
            {
                height = value;
            }
        }

        /// <summary>
        /// Initialise the canvas.
        /// </summary>
        /// <param name="width">The (strictly positive) width of the canvas.</param>
        /// <param name="height">The (strictly positive) height of the canvas.</param>
        public Canvas(int width = 80, int height = 28)
        {
            Width = width;
            Height = height;
            cells = new char[height, width];
            Clear();
        }

        /// <summary>
        /// Erase contents of canvas, replacing with spaces.
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
        /// Render the canvas to the standard output stream.
        /// </summary>
        public void Show()
        {
           //try
           //{
           //    Console.CursorLeft = 0;
           //    Console.CursorTop = 0;
           //}
           //catch
           //{
           //    // Do nothing, we expect this if the standard output stream is
           //    // not a terminal.
           //}

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
        /// If the row or column is out of bounds, then the canvas is not affected.
        /// Apart from the affected cell, all other cells in the canvas are unchanged.
        /// </summary>
        /// <param name="row">
        /// An integer which if within bounds will be the row of the cell affected.
        /// </param>
        /// <param name="col">
        /// An integer which if within bounds will be the column of the cell affected.
        /// </param>
        /// <param name="c">
        /// The symbol to render in the designated call.
        /// </param>
        public void Draw(int row, int col, char c)
        {
            if (row < 0 || row >= Height || col < 0 || col >= Width) return;

            cells[row, col] = c;
        }

        /// <summary>
        /// Adds a single line of text to the canvas, starting at the stipulated location.
        /// Any characters which fall within the bounds of the display are rendered.
        /// </summary>
        /// <param name="row">The row in which the first character will be displayed.</param>
        /// <param name="col">The column in which the first character will be displayed.</param>
        /// <param name="s">The non-null text to be added.</param>
        public void Draw(int col, int row, string s)
        {
            for (int i = 0; i < s.Length; i++)
                Draw(row, col + i, s[i]);
        }

        /// <summary>
        /// Utility method to interchange the values of two integer variables.
        /// </summary>
        /// <param name="a">One value.</param>
        /// <param name="b">The other value.</param>
        public static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        /// <summary>
        /// Adds a line to the canvas. Any points that fall outside the bounds
        /// are ignored.
        /// </summary>
        /// <param name="y0">The row in with the line starts.</param>
        /// <param name="x0">The column in which the line starts.</param>
        /// <param name="y1">The row in which the line ends.</param>
        /// <param name="x1">The column in which the line ends.</param>
        /// <param name="symbol">The symbol used to render the line.</param>
        public void Draw(int x0, int y0, int x1, int y1, char symbol)
        {
            double dx = (x1 - x0);
            double dy = (y1 - y0);
            double adx = Math.Abs(x1 - x0);
            double ady = Math.Abs(y1 - y0);

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
