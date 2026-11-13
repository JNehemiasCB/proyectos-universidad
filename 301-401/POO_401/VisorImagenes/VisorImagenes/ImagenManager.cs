using System.Drawing;
using System.Windows.Forms;

namespace VisorImagenes
{
    public class ImagenManager
    {
        private readonly PictureBox PicBox;
        private readonly OpenFileDialog OpFileDialog;
        private readonly ColorDialog ColDialog;

        public ImagenManager(PictureBox pictureBox, OpenFileDialog openFileDialog, ColorDialog colorDialog)
        {
            PicBox = pictureBox;
            OpFileDialog = openFileDialog;
            ColDialog = colorDialog;
        }

        public void MostrarImagen()
        {
            if (OpFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicBox.Load(OpFileDialog.FileName);
            }
        }

        public void BorrarImagen()
        {
            PicBox.Image = null;
        }

        public void CambiarColorFondo()
        {
            if (ColDialog.ShowDialog() == DialogResult.OK)
            {
                PicBox.BackColor = ColDialog.Color;
            }
        }

        public void AjustarImagen(bool ajustar)
        {
            PicBox.SizeMode = ajustar ? PictureBoxSizeMode.StretchImage : PictureBoxSizeMode.Normal;
        }
    }
}
