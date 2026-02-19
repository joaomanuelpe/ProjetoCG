using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCG
{
    internal class CMYK
    {
        private double C;
        private double M;
        private double Y;
        private double K;

        public CMYK(double c, double m, double y, double k)
        {
            C = c;
            M = m;
            Y = y;
            K = k;
        }

        public CMYK()
        {
            C = 0;
            M = 0;
            Y = 0;
            K = 0;
        }

        public double GetC()
        {
            return C;
        }
        public double GetM()
        {
            return M;
        }
        public double GetY()
        {
            return Y;
        }
        public double GetK()
        {
            return K;
        }


        public void SetC(double c)
        {
            this.C = c;
        }

        public void SetM(double m)
        {
            this.M = m;
        }

        public void SetY(double y)
        {
            this.Y=y;
        }

        public void SetK(double k)
        {
            this.K =k;
        }


        public void convertRGBtoCMYK(Color rgb)
        {
            convertRGBtoCMYK(rgb.R, rgb.G, rgb.B);
        }

        public void convertRGBtoCMYK(double r, double g, double b)
        {
            r = r / 255.0;
            g = g / 255.0;
            b = b / 255.0;
            K = 1 - Math.Max(r, Math.Max(g, b));
            if (K < 1)
            {
                C = (1 - r - K) / (1 - K);
                M = (1 - g - K) / (1 - K);
                Y = (1 - b - K) / (1 - K);
            }
            else
            {
                C = 0;
                M = 0;
                Y = 0;
            }
        }

        public Color convertCMYKtoRGB()
        {
            int r = (int)((1 - C) * (1 - K) * 255);
            int g = (int)((1 - M) * (1 - K) * 255);
            int b = (int)((1 - Y) * (1 - K) * 255);
            return Color.FromArgb(r, g, b);
        }
    }
}
