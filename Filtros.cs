using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCG
{
    internal class Filtros
    {

        // ---------------------------------- RGB's subtração ----------------------------
        internal static void buttonRmenos(Bitmap imgDestino)
        {
            int width = imgDestino.Width;
            int height = imgDestino.Height;

            BitmapData ImgSrcdata = imgDestino.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = ImgSrcdata.Stride;

            unsafe
            {
                byte* src = (byte*)ImgSrcdata.Scan0.ToPointer();

                int padding = stride - (width * 3);

                int red = src[2]; //aqui que vai começar a aplicar o filtro na imagem, pegando primeiro o valor inicial do vermelho
                // Pegando como base a explicação em aula (R,G,B) onde asubtrai-se somente o R, sendo assim (src--,1,1)

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        red = src[2] - 1;

                        if (red <= 0) //uma garantia para que nao fique abaixo do 0, pra nao dar b.o na imagem
                            red = 0;

                        src[2] = (byte)red;

                        src = (src += 3);
                    }
                    src += padding;
                }
            }
            imgDestino.UnlockBits(ImgSrcdata);
        }
        internal static void buttonGmenos(Bitmap imgDestino)
        {
            int width = imgDestino.Width;
            int height = imgDestino.Height;

            BitmapData ImgSrcdata = imgDestino.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = ImgSrcdata.Stride;

            unsafe
            {
                byte* src = (byte*)ImgSrcdata.Scan0.ToPointer();
                int padding = stride - (width * 3);
                int green = src[1];
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        green = src[1] - 1; 

                        if (green <= 0)
                            green = 0;

                        src[1] = (byte)green;
                        src = (src += 3);
                    }
                    src += padding;
                }
            }
            imgDestino.UnlockBits(ImgSrcdata);
        }

        internal static void buttonBmenos(Bitmap imgDestino)
        {
            int width = imgDestino.Width;
            int height = imgDestino.Height;

            BitmapData ImgSrcdata = imgDestino.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = ImgSrcdata.Stride;

            unsafe
            {
                byte* src = (byte*)ImgSrcdata.Scan0.ToPointer();
                int padding = stride - (width * 3);
                int blue = src[0];
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        blue = src[0] - 1;

                        if (blue <= 0)
                            blue = 0;

                        src[0] = (byte)blue;

                        src = (src + 3);
                    }
                    src += padding;
                }
            }
            imgDestino.UnlockBits(ImgSrcdata);
        }

        // ---------------------------------- RGB's adição ----------------------------
        internal static void buttonRmais(Bitmap imgDestino)
        {
            int width = imgDestino.Width;
            int height = imgDestino.Height;

            BitmapData ImgSrcdata = imgDestino.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = ImgSrcdata.Stride;

            unsafe
            {
                byte* src = (byte*)ImgSrcdata.Scan0.ToPointer();

                int padding = stride - (width * 3);

                int red = src[2]; //aqui que vai começar a aplicar o filtro na imagem, pegando primeiro o valor inicial do vermelho
                // Pegando como base a explicação em aula (R,G,B) onde aumenta-se somente o R, sendo assim (src++,1,1)

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        red = src[2] + 5;

                        if (red > 255) //uma garantia para que nao passe do 255, pra nao dar b.o na imagem
                            red = 255;

                        src[2] = (byte)red;

                        src = (src += 3);
                    }
                    src += padding;
                }
            }
            imgDestino.UnlockBits(ImgSrcdata);
        }

        internal static void buttonGmais(Bitmap imgDestino)
        {
            int width = imgDestino.Width;
            int height = imgDestino.Height;

            BitmapData ImgSrcdata = imgDestino.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = ImgSrcdata.Stride;

            unsafe
            {
                byte* src = (byte*)ImgSrcdata.Scan0.ToPointer();
                int padding = stride - (width * 3);
                int green = src[1];
                for (int y = 0; y < height; y++)
                {
                    for(int x = 0; x < width; x++)
                    {
                        green = src[1]+5;

                        if (green > 255)
                            green = 255;

                        src[1] = (byte)green;

                        src = (src += 3);
                    }
                    src += padding;
                } 
            }
            imgDestino.UnlockBits(ImgSrcdata);
        }

        internal static void buttonBmais(Bitmap imgDestino)
        {
            int width = imgDestino.Width;
            int height = imgDestino.Height;

            BitmapData ImgSrcdata = imgDestino.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = ImgSrcdata.Stride;

            unsafe
            {
                byte* src = (byte*)ImgSrcdata.Scan0.ToPointer();
                int padding = stride - (width * 3);
                int blue = src[0];
                for(int y = 0; y < height; y++)
                {
                    for(int x = 0; x < width; x++)
                    {
                        blue = src[0] + 5;

                        if (blue > 255)
                            blue = 255;

                        src[0] = (byte)blue;

                        src = (src + 3);
                    }
                    src += padding;
                }
            }
            imgDestino.UnlockBits(ImgSrcdata);
        }

        // ------------------------------ Luminancia --------------------------------
        internal static void LuminanciaDMA(Bitmap imageBitmap, Bitmap imgDest)
        {
            int width = imageBitmap.Width;
            int height = imageBitmap.Height;
            int pixelSize = 3;
            Int32 gs;

            BitmapData bitmapDataSrc = imageBitmap.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bitmapDataDst = imgDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src++);
                        g = *(src++);
                        r = *(src++);
                        gs = (Int32)(r * 0.2990 + g * 0.5870 + b * 0.1140);
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                    }
                    src += padding;
                    dst += padding;
                }
            }
            imageBitmap.UnlockBits(bitmapDataSrc);
            imgDest.UnlockBits(bitmapDataDst);
        }

        public static Image BrilhoEspecifico(Bitmap imageBitmap, int valorBrilho)
        {
            int width = imageBitmap.Width;
            int height = imageBitmap.Height;
            int pixelSize = 3;
            Bitmap imgDest = new Bitmap(width, height);

            BitmapData bitmapDataSrc = imageBitmap.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bitmapDataDst = imgDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            HSI hsi = new HSI();
            Color rgb;
            int r, g, b;
            unsafe
            { 
                byte* srcBase = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dstBase = (byte*)bitmapDataDst.Scan0.ToPointer();
                byte* src, dst;
                for (int y = 0; y < height; y++)
                {
                    src = srcBase + y * bitmapDataSrc.Stride;
                    dst = dstBase + y * bitmapDataDst.Stride;
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src++);
                        g = *(src++);
                        r = *(src++);
                        //hsi.convertRGBtoHSI(*(src+2), *(src + 1),*src);
                        hsi.convertRGBtoHSI(r,g,b);
                        hsi.setI((int)(hsi.getI()*(1+valorBrilho/100.0)));
                        rgb = hsi.convertHSItoRGB();
                        *(dst++) = rgb.B;
                        *(dst++) = rgb.G;
                        *(dst++) = rgb.R;
                        
                    }
                }
            }
            imageBitmap.UnlockBits(bitmapDataSrc);
            imgDest.UnlockBits(bitmapDataDst);

            return imgDest;
        }
    }
}
