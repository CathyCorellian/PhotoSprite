using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PhotoSprite
{
    class HSL
    {
        public float H;
        public float S;
        public float L;

        public Color ToColor()
        {
            return Color.Black;
        }

        public void FromRGB(Color color)
        {
            H = color.GetHue();
            S = color.GetSaturation();
            L = color.GetBrightness();
        }
    }
}
