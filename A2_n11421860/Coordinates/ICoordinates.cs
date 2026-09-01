using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace A2_n11421860
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
