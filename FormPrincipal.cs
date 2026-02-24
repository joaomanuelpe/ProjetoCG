

namespace ProjCG
{
    public partial class FormPrincipal : Form
    {
        private Image image;
        private Bitmap imageBitmap;
        private HSI[][] imagemHSI;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbirImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pictureBoxOrigem.Image = image;
                pictureBoxOrigem.SizeMode = PictureBoxSizeMode.Normal;
                imagemHSI = Filtros.ConverterRGBparaHSI((Bitmap)image);
            }
            if (pictureBoxDestino.Image != null) //verifica se tem imagem na outra tela, se houver, retira ela
                pictureBoxDestino.Image = null;
        }

        private void btnLuminancia_Click(object sender, EventArgs e)
        {
            Bitmap imgDest = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            Filtros.LuminanciaDMA(imageBitmap, imgDest);
            pictureBoxDestino.Image = imgDest;
        }


        private void pictureBoxOrigem_MouseMove(object sender, MouseEventArgs e)
        {

            if (pictureBoxOrigem.Image != null)
            {
                Bitmap bmp = (Bitmap)pictureBoxOrigem.Image;
                if (e.X >= 0 && e.X < bmp.Width && e.Y >= 0 && e.Y < bmp.Height)
                {
                    Color cor = bmp.GetPixel(e.X, e.Y);
                    lbRgb.Text = "(" + cor.R + "," + cor.G + "," + cor.B + ")";
                    HSI hsi = new HSI();
                    hsi.convertRGBtoHSI(cor);
                    lbHsi.Text = "(" + hsi.getH() + "," + hsi.getS() + "," + hsi.getI() + ")";
                    CMYK cmyk = new CMYK();
                    cmyk.convertRGBtoCMYK(cor);
                    lbCmy.Text = "(" + (int)(cmyk.GetC() * 100) + "," + (int)(cmyk.GetM() * 100) + "," + (int)(cmyk.GetY() * 100) + ")";

                }
            }
            else
            {
                lbRgb.Text = "(255,255,255)";
                lbCmy.Text = "(255,255,255)";
                lbHsi.Text = "(255,255,255)";
            }

        }

        private void tbBrilho_Scroll(object sender, EventArgs e)
        {
            int valorBrilho = tbBrilho.Value;
            lbBrilho.Text = "" + valorBrilho;


        }

        private void btImagemOriginal_Click(object sender, EventArgs e)
        {
            if (image != null)
                pictureBoxOrigem.Image = image;
        }

        private void btDiminuiI_Click(object sender, EventArgs e)
        {
            int valorBrilho = tbBrilho.Value * -1;

            if (pictureBoxOrigem.Image != null)
            {
                Bitmap imgOrigem = (Bitmap)pictureBoxOrigem.Image;
                pictureBoxOrigem.Image = Filtros.BrilhoEspecifico(imgOrigem, valorBrilho, imagemHSI);
            }
        }

        private void btAumentaI_Click(object sender, EventArgs e)
        {
            int valorBrilho = tbBrilho.Value;

            if (pictureBoxOrigem.Image != null)
            {
                Bitmap imgOrigem = (Bitmap)pictureBoxOrigem.Image;
                pictureBoxOrigem.Image = Filtros.BrilhoEspecifico(imgOrigem, valorBrilho, imagemHSI);
            }
        }

        private void btnAumentarHue30_Click(object sender, EventArgs e)
        {
            if (pictureBoxOrigem.Image != null)
            {
                Bitmap imgOrigem = (Bitmap)pictureBoxOrigem.Image;
                pictureBoxDestino.Image = Filtros.AjustarHue30((Bitmap)pictureBoxOrigem.Image, 30, imagemHSI);
            }
        }

        private void btnDiminuirHue30_Click(object sender, EventArgs e)
        {
            if (pictureBoxOrigem.Image != null)
            {
                Bitmap imgOrigem = (Bitmap)pictureBoxOrigem.Image;
                pictureBoxDestino.Image = Filtros.AjustarHue30((Bitmap)pictureBoxOrigem.Image, -30, imagemHSI);
            }
        }

        private void btnSegHUE_Click(object sender, EventArgs e)
        {
            if (pictureBoxOrigem.Image != null)
            {
                int num = (int)numericUpDownHue.Value;
                int num2 = (int)numericUpDownHue2.Value;
                Bitmap imgOrigem = (Bitmap)pictureBoxOrigem.Image;
                pictureBoxOrigem.Image = Filtros.SegmentarHUE(imgOrigem, num, num2, imagemHSI);
            }
        }
        
        private void btnMiniaturasHSI_Click(object sender, EventArgs e)
        {
            if (pictureBoxOrigem.Image != null)
            {
                Bitmap imgOrigem = (Bitmap)pictureBoxOrigem.Image;
                pictureBoxDestino.Image = Filtros.MiniaturaHSI(imgOrigem, imagemHSI);
                pictureBoxDestino.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }
        
    }
}
