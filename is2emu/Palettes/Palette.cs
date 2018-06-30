using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
namespace is2emu
{
    public class Palette
    {
        /// <summary>
        /// Base for palettes based upon dBZ scale below (most is optional)
        /// </summary>
        public class dBZBase
        {
            /// <summary>
            /// Color used for less than or equal to 5 dBZ
            /// </summary>
            public Color dBZ5;
            public Color dBZ10;
            public Color dBZ20;
            public Color dBZ30;
            public Color dBZ35;
            public Color dBZ45;
            public Color dBZ55;
            public Color dBZ65;
            public Color dBZ75;
            /// <summary>
            /// Color used for 85 dBZ or higher
            /// </summary>
            public Color dBZ85P;
        }

        public dBZBase rainPalette;
        public dBZBase mixPalette;
        public dBZBase snowPalette;
    }
}
