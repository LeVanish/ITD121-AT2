using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace A2_n11421860
{
    /// <summary>
    /// The contract satisfied by objects which can be drawn on a canvas.
    /// </summary>
    public interface IDrawable
    {

        /// <summary>
        /// Render an object in the specified canvas.
        /// </summary>
        /// <param name="canvas">The non-null canvas which will display the object.</param>
        void Draw(Canvas canvas);
    }
}
