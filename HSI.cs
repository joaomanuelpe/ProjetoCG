using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCG
{
    internal class HSI
    {
        private int h, s, i;

        public HSI(int h, int s, int i)
        {
            this.h = h;
            this.s = s;
            this.i = i;
        }

        public HSI()
        {
            this.h = 0;
            this.s = 0;
            this.i = 0;
        }

        public int getH() { return this.h; }
        public int getS() { return this.s; }
        public int getI() { return this.i; }

        public void setH(int h) { this.h = h; }
        public void setS(int s) { this.s = s; }
        public void setI(int i) { this.i = i; }

        public void convertRGBtoHSI(Color cor)
        {
            convertRGBtoHSI(cor.R, cor.G, cor.B);
        }
        public void convertRGBtoHSI(double r, double g, double b)
        {
            double soma = r + g + b;
            i = calculateI(r, g, b);
            r=r / soma;
            g=g / soma;
            b=b / soma;
            h= calculateH(r, g, b);
            s=calculateS(r, g, b);
        }

        private int calculateI(double r, double g, double b)
        {
            return (int)((r + g + b) / 3); 
        }

        private int calculateS(double r, double g, double b)
        {
            double min = Math.Min(r, Math.Min(g, b));
            return (int)((1 - 3 * min)*100);
        }


        private int calculateH(double r, double g, double b)
        {
            double denominador = Math.Sqrt(Math.Pow((r - g), 2) + (r - b) * (g - b));
            if(denominador==0)
                return 0;
            double numerador = 0.5 * ((r - g) + (r - b));
            double result=Math.Acos( numerador / denominador);
            result = result * 180 / Math.PI; // Converte para graus

            if (b > g)
                return (int)(360 - result + 0.5);
            else
                return (int)(result + 0.5);
        }

        public Color convertHSItoRGB()
        {
            double H = this.h * Math.PI / 180.0;
            double S = this.s / 100.0;
            double I = this.i / 255.0;

            double r = 0, g = 0, b = 0;

            double x, y, z;

            if (H < 2 * Math.PI / 3)
            {
                x = I * (1 - S);

                y = I * (1 + (S * Math.Cos(H)) / Math.Cos(Math.PI / 3 - H));

                z = 3 * I - (x + y);

                b = x;
                r = y;
                g = z;
            }
            else if (H < 4 * Math.PI / 3)
            {
                H = H - 2 * Math.PI / 3;

                x = I * (1 - S);

                y = I * (1 + (S * Math.Cos(H)) / Math.Cos(Math.PI / 3 - H));

                z = 3 * I - (x + y);

                r = x;
                g = y;
                b = z;
            }
            else
            {
                H = H - 4 * Math.PI / 3;

                x = I * (1 - S);

                y = I * (1 + (S * Math.Cos(H)) / Math.Cos(Math.PI / 3 - H));

                z = 3 * I - (x + y);

                g = x;
                b = y;
                r = z;
            }

            return Color.FromArgb(
                Corrija((int)(r * 255)),
                Corrija((int)(g * 255)),
                Corrija((int)(b * 255))
            );
        }


        private int Corrija(int v)  // Nome corrigido (minúsculo)
        {
            if (v < 0) return 0;
            if (v > 255) return 255;
            return v;
        }
    }
}
