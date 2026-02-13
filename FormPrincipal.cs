

namespace ProjCG
{
    public partial class FormPrincipal : Form
    {
        private Image image;
        private Bitmap imageBitmap;
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

        private void btnR_Click(object sender, EventArgs e)
        {
            if (pictureBoxDestino.Image == null) //Faço isso para verificar se tem uma imagem destino, para garantir que nao sobrescreva a imagem original toda vez que clicar no botão
            {
                Bitmap imgOrigem = (Bitmap)pictureBoxOrigem.Image;
                pictureBoxDestino.Image = (Bitmap)imgOrigem.Clone();
            }

            Bitmap imgDestino = (Bitmap)pictureBoxDestino.Image;
            Filtros.buttonRmais(imgDestino);
            pictureBoxDestino.Refresh(); //Cereja do bolo para atualizar a imagem toda vez que clicar no botão
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if(pictureBoxDestino.Image == null)
            {
                Bitmap imgOrigem = (Bitmap)pictureBoxOrigem.Image;
                pictureBoxDestino.Image = (Bitmap)imgOrigem.Clone();
            }
            Bitmap imgDestino = (Bitmap)pictureBoxDestino.Image;
            Filtros.buttonGmais(imgDestino);
            pictureBoxDestino.Refresh();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if(pictureBoxDestino.Image == null)
            {
                Bitmap imgOrigem = (Bitmap)pictureBoxOrigem.Image;
                pictureBoxDestino.Image = (Bitmap)imgOrigem.Clone();
            }
            Bitmap imgDestino = (Bitmap)pictureBoxDestino.Image;
            Filtros.buttonBmais(imgDestino);
            pictureBoxDestino.Refresh();
        }

        private void btnRmenos_Click(object sender, EventArgs e)
        {
            if (pictureBoxDestino.Image == null)
            {
                Bitmap imgOrigem = (Bitmap)pictureBoxOrigem.Image;
                pictureBoxDestino.Image = (Bitmap)imgOrigem.Clone();
            }
            Bitmap imgDestino = (Bitmap)pictureBoxDestino.Image;
            Filtros.buttonRmenos(imgDestino);
            pictureBoxDestino.Refresh();
        }

        private void btnGmenos_Click(object sender, EventArgs e)
        {
            if (pictureBoxDestino.Image == null)
            {
                Bitmap imgOrigem = (Bitmap)pictureBoxOrigem.Image;
                pictureBoxDestino.Image = (Bitmap)imgOrigem.Clone();
            }
            Bitmap imgDestino = (Bitmap)pictureBoxDestino.Image;
            Filtros.buttonGmenos(imgDestino);
            pictureBoxDestino.Refresh();
        }

        private void btnBmenos_Click(object sender, EventArgs e)
        {
            if (pictureBoxDestino.Image == null)
            {
                Bitmap imgOrigem = (Bitmap)pictureBoxOrigem.Image;
                pictureBoxDestino.Image = (Bitmap)imgOrigem.Clone();
            }
            Bitmap imgDestino = (Bitmap)pictureBoxDestino.Image;
            Filtros.buttonBmenos(imgDestino);
            pictureBoxDestino.Refresh();
        }
    }
}
