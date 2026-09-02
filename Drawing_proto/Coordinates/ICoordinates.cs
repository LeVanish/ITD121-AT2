using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Drawing_proto
{
    /// <summary>
    /// An abstract representation of an (X,Y) position.
    /// </summary>
    public interface ICoordinates
    {
        /// <summary>
        /// Gets the horizontal coordinate.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Gets the vertical coordinate.
        /// </summary>
        public int Y { get; }
    }
}
