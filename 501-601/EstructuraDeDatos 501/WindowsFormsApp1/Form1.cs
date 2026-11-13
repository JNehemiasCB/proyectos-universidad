using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Timer timer;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // evita parpadeos
            this.Paint += Form1_Paint;

            // Crear y configurar un Timer SIN usar el diseñador
            timer = new Timer();
            timer.Interval = 1000; // cada 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Invalidate(); // repinta el formulario -> genera nuevos puntos
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Dibujar pecera rectangular
            int peceraX = 50;
            int peceraY = 50;
            int peceraAncho = 200;
            int peceraAlto = 120;

            g.FillRectangle(Brushes.LightBlue, peceraX, peceraY, peceraAncho, peceraAlto);
            g.DrawRectangle(Pens.Blue, peceraX, peceraY, peceraAncho, peceraAlto);

            // Dibujar varios puntos aleatorios dentro de la pecera
            for (int i = 0; i < 5; i++) // 5 burbujas
            {
                int puntoX = random.Next(peceraX, peceraX + peceraAncho - 8);
                int puntoY = random.Next(peceraY, peceraY + peceraAlto - 8);

                g.FillEllipse(Brushes.Red, puntoX, puntoY, 8, 8);
            }
        }
    }
}
