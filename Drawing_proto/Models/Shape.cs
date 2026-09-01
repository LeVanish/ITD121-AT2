using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    public abstract class Shape : IDrawable
    {
        Canvas Canvas = new Canvas();
        /// <summary>
        ///     Gets the position of the "top-left" corner of the object.
        /// </summary>
        public ICoordinates Position { get; }

        /// <summary>
        ///     Gets the width of the object.
        /// </summary>
        public virtual int Width { get; }

        /// <summary>
        ///     Gets the height of the object.
        /// </summary>
        public virtual int Height { get; }

        /// <summary>
        ///     Initialise a shape
        /// </summary>
        /// <param name="position"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Shape(ICoordinates position, int width, int height)
        {
            Position = position;
            Width = width;
            Height = height;
        }

        /// <summary>
        ///     Override Draw to render a shape.
        /// </summary>
        /// <param name="canvas">
        ///     The non-null canvas to which the shape will be added.
        /// </param>
        public abstract void Draw(Canvas canvas);

    }
}

