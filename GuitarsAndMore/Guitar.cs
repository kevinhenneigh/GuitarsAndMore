using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarsAndMore
{
    // Properties
    // GuitarId, Brand, GuitarType, Color, Value

    /// <summary>
    /// Represents a single guitar
    /// </summary>
    class Guitar
    {
        #region Properties
        public int GuitarId { get; set; }

        /// <summary>
        /// Maker of this guitar ex. Gibson, Fender
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Style of this guitar ex. Telecaster, Les Paul
        /// </summary>
        public string GuitarType { get; set; }

        /// <summary>
        /// Color of this guitar ex. Red and White, Blue
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// The retail price associated with this guitar ex. 699.99
        /// </summary>
        public double Value { get; set; }

        #endregion
    }
}
