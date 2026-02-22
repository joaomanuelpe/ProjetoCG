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
                    for (int x = 0; x < width; x++)
                    {
                        green = src[1] + 5;

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
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
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

        public static Image BrilhoEspecifico(Bitmap imageBitmap, int valorBrilho, HSI[][] imagemHSI)
        {
            int width = imageBitmap.Width;
            int height = imageBitmap.Height;

            Bitmap imgDest = new Bitmap(width, height);

            BitmapData bitmapDataSrc = imageBitmap.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bitmapDataDst = imgDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            HSI hsi;
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
                        hsi = imagemHSI[y][x];
                        int i = (int)(hsi.getI() + 255 * valorBrilho / 100.0);
                        if (i > 255)
                            hsi.setI(255);
                        else if (i < 0)
                            hsi.setI(0);
                        rgb = hsi.convertHSItoRGB();
                        hsi.setI(i);
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

        public static HSI[][] ConverterRGBparaHSI(Bitmap imageBitmap)
        {
            int width = imageBitmap.Width;
            int height = imageBitmap.Height;

            HSI[][] hsiImagem = new HSI[height][];

            BitmapData bitmapDataSrc = imageBitmap.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);


            HSI hsi;

            int r, g, b;
            unsafe
            {
                byte* srcBase = (byte*)bitmapDataSrc.Scan0.ToPointer();

                byte* src;
                for (int y = 0; y < height; y++)
                {
                    src = srcBase + y * bitmapDataSrc.Stride;
                    hsiImagem[y] = new HSI[width];
                    for (int x = 0; x < width; x++)
                    {
                        hsi = new HSI();
                        b = *(src++);
                        g = *(src++);
                        r = *(src++);
                        //hsi.convertRGBtoHSI(*(src+2), *(src + 1),*src);
                        hsi.convertRGBtoHSI(r, g, b);
                        hsiImagem[y][x] = hsi;


                    }
                }
            }
            imageBitmap.UnlockBits(bitmapDataSrc);

            return hsiImagem;
        }

        public static Bitmap ajustarHSI(Bitmap img, int deltaH, float fatorI)
        {
            int width = img.Width;
            int height = img.Height;

            Bitmap imgDest = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            BitmapData srcData = img.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);

            BitmapData dstData = imgDest.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);

            int strideSrc = srcData.Stride;
            int strideDst = dstData.Stride;

            HSI hsi = new HSI();

            unsafe
            {
                byte* ptrSrc = (byte*)srcData.Scan0;
                byte* ptrDst = (byte*)dstData.Scan0;

                for (int y = 0; y < height; y++)
                {
                    byte* rowSrc = ptrSrc + y * strideSrc;
                    byte* rowDst = ptrDst + y * strideDst;

                    for (int x = 0; x < width; x++)
                    {
                        byte b = rowSrc[x * 3];
                        byte g = rowSrc[x * 3 + 1];
                        byte r = rowSrc[x * 3 + 2];

                        hsi.convertRGBtoHSI(r, g, b);
                        //ajusta hue
                        int novoH = hsi.getH() + deltaH;

                        if (novoH < 0)
                            novoH += 360;
                        if (novoH >= 360)
                            novoH -= 360;

                        hsi.setH(novoH);

                        //ajusta i
                        int novoI = (int)(hsi.getI() * fatorI);

                        if (novoI < 0)
                            novoI = 0;
                        if (novoI > 255)
                            novoI = 255;
                        hsi.setI(novoI);
                        Color novaCor = hsi.convertHSItoRGB();

                        rowDst[x * 3] = novaCor.B;
                        rowDst[x * 3 + 1] = novaCor.G;
                        rowDst[x * 3 + 2] = novaCor.R;
                    }
                }
            }

            img.UnlockBits(srcData);
            imgDest.UnlockBits(dstData);

            return imgDest;
        }

        // ---------------------------- Segmentar pelo HUE ---------------------
        public static Bitmap SegmentarHUE(Bitmap imageBitmap, double hueAlvo, double tolerancia, HSI[][] imagemHSI)
        {
            int width = imageBitmap.Width;
            int height = imageBitmap.Height;
            Bitmap imgDest = new Bitmap(width, height);

            BitmapData bitmapDataSrc = imageBitmap.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData bitmapDataDst = imgDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

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
                        byte b = *(src++);
                        byte g = *(src++);
                        byte r = *(src++);

                        // pega o hue da matriz ja pre calculado
                        HSI hsi = imagemHSI[y][x];
                        double pixelH = hsi.getH();

                        // faz o calculo do circulo
                        double diferenca = Math.Abs(pixelH - hueAlvo);
                        if (diferenca > 180)
                            diferenca = 360 - diferenca;

                        // Se a cor especificada estiver na imagem, copa o RGB original para o destino
                        if (diferenca <= tolerancia)
                        {
                            *(dst++) = b;
                            *(dst++) = g;
                            *(dst++) = r;
                        }
                        else
                        {
                            // Aqui faz a luminancia pro local da imagem na qual nao corresponde com o RGB daquele determinado grau solicitado
                            byte cinza = (byte)(r * 0.299 + g * 0.587 + b * 0.114);
                            *(dst++) = cinza;
                            *(dst++) = cinza;
                            *(dst++) = cinza;
                        }
                    }
                }
            }
            imageBitmap.UnlockBits(bitmapDataSrc);
            imgDest.UnlockBits(bitmapDataDst);

            return imgDest;
        }

    }
}
