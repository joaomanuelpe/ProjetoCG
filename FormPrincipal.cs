

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
            if(openFileDialog.ShowDialog() == DialogResult.OK) { 
                image = Image.FromFile(openFileDialog.FileName);
                pictureBoxOrigem.Image = image;
                pictureBoxOrigem.SizeMode = PictureBoxSizeMode.Normal;
            }
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
            Filtros.buttonR(imgDestino);
            pictureBoxDestino.Refresh(); //Cereja do bolo para atualizar a imagem toda vez que clicar no botão
        }
    }
}
