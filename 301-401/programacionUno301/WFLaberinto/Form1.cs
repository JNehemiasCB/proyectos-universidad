using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WFLaberinto
{
    public partial class Form1 : Form
    {
        SoundPlayer startingSoundPlayer =  new SoundPlayer(@"C:\\Windows\Media\notify.wav");
        SoundPlayer finishSoundPlayer = new SoundPlayer(@"C:\\Windows\Media\tada.wav");
        SoundPlayer TocarMuro = new SoundPlayer(@"C:\\Windows\Media\Windows ding.wav");
        public Form1()
        {
            InitializeComponent();
            MueveAlInicio();
        }

        private void lblMeta_MouseEnter(object sender, EventArgs e)
        {
            //ejecuta sonido y muestra un msj de felicitaciones
            finishSoundPlayer.Play();
            MessageBox.Show("¡Felicidades!","Ganaste");
            MueveAlInicio();
        }
        /// <summary>
        /// ejecuta un sonido y entonces Mueve el apuntador 185 pixeles
        /// a la derecha y 335 pixeles hacia abajo del punto inicial del juego 
        /// </summary>
        private void MueveAlInicio()
        {
            Point start = panel1.Location;
            start.Offset(180, 330);
            Cursor.Position = PointToScreen(start);
            startingSoundPlayer.Play();
        }

        private void muro_MouseEnter(object sender, EventArgs e)
        {
            //cuando el apuntador del mouse toca un muro o se introduce a el
            //llama al metodo TocarMuro y reproduce un sonido 
            TocarMuro.Play();
            Point startPoint = panel1.Location;
            startPoint.Offset(180, 330);
            Cursor.Position = PointToScreen(startPoint);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
