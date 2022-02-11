using System;
namespace Exercise7
{
    public class Color
    {
        public int red { get; set; }
        public int green { get; set; }
        public int blue { get; set; }
        public int alpha { get; set; }

        public Color(int r, int g, int b, int a = 255)
        {
            red = r;
            green = g;
            blue = b;
            alpha = a;
        }

        public double grayScale()
        {
            return (red + green + blue) / 3;
        }

    }
}
