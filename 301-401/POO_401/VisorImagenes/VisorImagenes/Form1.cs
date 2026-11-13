using System;
using System.Windows.Forms;

namespace VisorImagenes
{
    public partial class Form1 : Form
    {
        private ImagenManager imagenManager;

        public Form1()
        {
            InitializeComponent();

            // Inyección de controles al manejador de lógica
            imagenManager = new ImagenManager(pictureBox1, openFileDialog1, colorDialog1);

            // Asociar eventos a métodos del manejador
            btnMostrar.Click += (s, e) => imagenManager.MostrarImagen();
            btnBorrar.Click += (s, e) => imagenManager.BorrarImagen();
            btnColorFondo.Click += (s, e) => imagenManager.CambiarColorFondo();
            btnCerrar.Click += (s, e) => this.Close();
            CheckBox1.CheckedChanged += (s, e) =>
            {
                imagenManager.AjustarImagen(CheckBox1.Checked);
            };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

