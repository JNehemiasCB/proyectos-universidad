using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFListBox
{
    public partial class Form1 : Form
    {
        private ArchivoTexto Archivo;
        public Form1(String rutaArchivo)
        {
            Archivo = new ArchivoTexto(rutaArchivo);
            InitializeComponent();
            Archivo.CrearArchivo();
            btnAceptar.Text = "Aceptar";
            lblNombre.Text = "Nombre";
            CargarTextoEnListBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Prueba de escritura en archivo de texto";
        }

        private void CargarTextoEnListBox()
        {
            string texto = Archivo.LeerTexto();
            string[] lineas = texto.Split(new[] { Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);
            lstBoxNombres.Items.AddRange(lineas);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string texto = txtNombre.Text;
            if(!string.IsNullOrEmpty(texto))
            {
                Archivo.EscribirTexto(texto);
                lstBoxNombres.Items.Add(texto);
                txtNombre.Clear();
            }
        }
    }
}
