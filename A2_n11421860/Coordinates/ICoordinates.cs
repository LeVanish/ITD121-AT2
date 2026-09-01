using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// Abstract representation of an (x,y) position.
    /// </summary>
    public interface ICoordinates
    {
        /// <summary>
        /// Get the horizontal offset to the position.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Get the vertical offset of the position.
        /// </summary>
        public int Y { get; }
    }
}
