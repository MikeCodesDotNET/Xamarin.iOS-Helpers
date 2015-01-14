using System;
using UIKit;

namespace MikeJames
{
    public static class Colours
    {
        public static UIColor ToUIColor(this string hexString)
        {
            hexString = hexString.Replace("#", "");

            if (hexString.Length == 3)
                hexString = hexString + hexString;

            if (hexString.Length != 6)
                throw new Exception("Invalid hex string");

            int red = Int32.Parse(hexString.Substring(0,2), System.Globalization.NumberStyles.AllowHexSpecifier);
            int green = Int32.Parse(hexString.Substring(2,2), System.Globalization.NumberStyles.AllowHexSpecifier);
            int blue = Int32.Parse(hexString.Substring(4,2), System.Globalization.NumberStyles.AllowHexSpecifier);

            return UIColor.FromRGB(red, green, blue);
        }
    
        public static UIColor Lighten(this UIColor color, int steps)
        {
            int modifier = 16 * steps;

            nfloat rF, gF, bF, aF;
            color.GetRGBA(out rF, out gF, out bF, out aF);

            int r, g, b, a;
            r = (int)Math.Ceiling(rF * 255);
            g = (int)Math.Ceiling(gF * 255);
            b = (int)Math.Ceiling(bF * 255);
            a = (int)Math.Ceiling(aF * 255);

            r += modifier;
            g += modifier;
            b += modifier;
            // leave 'a' alone?

            r = r > 255 ? 255 : r;
            g = g > 255 ? 255 : g;
            b = b > 255 ? 255 : b;

            return UIColor.FromRGBA(r, g, b, a);
        }

        public static UIColor Darken(this UIColor color, int steps)
        {
            int modifier = 16 * steps;

            nfloat rF, gF, bF, aF;

            color.GetRGBA(out rF, out gF, out bF, out aF);

            int r, g, b, a;
            r = (int)Math.Ceiling(rF * 255);
            g = (int)Math.Ceiling(gF * 255);
            b = (int)Math.Ceiling(bF * 255);
            a = (int)Math.Ceiling(aF * 255);

            r -= modifier;
            g -= modifier;
            b -= modifier;
            // leave 'a' alone?

            r = r < 0 ? 0 : r;
            g = g < 0 ? 0 : g;
            b = b < 0 ? 0 : b;

            return UIColor.FromRGBA(r, g, b, a);
        }
    }
}

