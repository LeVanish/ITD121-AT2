using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// Defines an object that can be rendered onto a canvas.
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// Renders the object onto the specified canvas.
        /// </summary>
        /// <param name="canvas">The canvas on which the object is rendered.</param>
        void Draw(Canvas canvas);
    }
}
