using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// Base class for all drawable shapes in the application.
    /// </summary>
    public abstract class Shape : IDrawable
    {
        Canvas Canvas = new Canvas();
        /// <summary>
        /// Gets the position of the shape's top-left corner.
        /// </summary>
        public ICoordinates Position { get; }

        /// <summary>
        /// Gets the width of the shape.
        /// </summary>
        public virtual int Width { get; }

        /// <summary>
        /// Gets the height of the shape.
        /// </summary>
        public virtual int Height { get; }

        /// <summary>
        /// Creates a shape with the specified position and dimensions.
        /// </summary>
        /// <param name="position">The top-left position of the shape.</param>
        /// <param name="width">The wisth of the shape.</param>
        /// <param name="height">The height of the shape.</param>
        public Shape(ICoordinates position, int width, int height)
        {
            Position = position;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Renders the shape onto the canvas.
        /// </summary>
        /// <param name="canvas">The canvas to which the shape is rendered.</param>
        public abstract void Draw(Canvas canvas);

    }
}

