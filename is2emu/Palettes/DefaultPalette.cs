using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
namespace is2emu.Palettes
{
    class DefaultPalette : Palette
    {
        private DefaultPalette() {
            rainPalette = new Palette.dBZBase
            {
                dBZ5 = new Color(128, 225, 128),
                dBZ10 = new Color(64, 160, 64),
                dBZ20 = new Color(32, 112, 32),
                dBZ30 = new Color(0, 65, 0),
                dBZ35 = new Color(255, 255, 0),
                dBZ45 = new Color(225, 127, 0),
                dBZ55 = new Color(255, 0, 0),
                dBZ65 = new Color(128, 0, 0),
                dBZ75 = new Color(254, 85, 254),
                dBZ85P = new Color(255, 255, 255)
            };
            mixPalette = new Palette.dBZBase
            {
                dBZ5 = new Color(255, 192, 192),
                dBZ30 = new Color(255, 158, 158),
                dBZ45 = new Color(255, 124, 124),
                dBZ55 = new Color(255, 99, 99)
            };
            snowPalette = new Palette.dBZBase
            {
                dBZ5 = new Color(55, 255, 255),
                dBZ10 = new Color(43, 212, 254),
                dBZ20 = new Color(31, 169, 255),
                dBZ30 = new Color(19, 126, 255),
                dBZ35 = new Color(11, 97, 255),
                dBZ45 = new Color(0, 55, 255)
            };
            // The above palettes are "official" (straight from TWC API docs.)
        }

        private static readonly DefaultPalette instance = new DefaultPalette();
        public static DefaultPalette GetInstance()
        {
            return instance;
        }
    }
}
