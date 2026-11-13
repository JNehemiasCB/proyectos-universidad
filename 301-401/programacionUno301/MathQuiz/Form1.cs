using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        //Cree un objeto aleatorio llamado 
        //aleatorizador para generar números aleatorios.
        Random randomizer = new Random();

        //Estas variables enteras almacenan 
        //los números para el problema de suma
        int addend1;
        int addend2;

        //Estas variables enteras almacenan 
        //los números para el problema de resta.
        int minuend;
        int subtrahend;

        // Estas variables enteras almacenan 
        //los números para el problema de multiplicación. 
        int multiplicand;
        int multiplier;

        //Estas variables enteras almacenan 
        //los números para el problema de división. 
        int dividend;
        int divisor;

        // Esta variable entera 
        //realiza un seguimiento del tiempo restante.
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Comience el cuestionario completando 
        /// todos los problemas e iniciando el cronómetro.
        /// </summary>
        public void StartTheQuiz()
        {
            // Completa el problema de suma.
            // Genera dos números aleatorios para sumar.
            // Almacena los valores en las variables 'addend1' y 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convierta los dos números generados 
            //aleatoriamente en cadenas para que 
            //puedan mostrarse en los controles de etiqueta.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sumar' es el nombre del control NumericUpDown. 
            //Este paso asegura que su valor sea cero 
            //antes de agregarle cualquier valor.
            sumar.Value = 0;

            // Completa el problema de resta.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            // Completa el problema de la multiplicación.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            // Completa el problema de la división.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            // Inicia el cronómetro.
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        /// <summary>
        /// Verifique las respuestas para ver si el usuario hizo todo bien.
        /// </summary>
        /// <returns>Verdadero si la respuesta es correcta, falso en caso contrario.</returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sumar.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // Si CheckTheAnswer() devuelve verdadero,
                //entonces el usuario respondió correctamente.
                //Detenga el cronómetro y muestre un cuadro de mensaje.
                timer1.Stop();
                MessageBox.Show("¡Tienes todas las respuestas correctas!",
                                "Bien echo!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Si CheckTheAnswer() devuelve falso,
                // sigue la cuenta regresiva.
                // Disminuya el tiempo restante en un segundo
                // y muestre el nuevo tiempo restante
                // actualizando la etiqueta Tiempo restante.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }

            else
            {
                // Si al usuario se le acabó el tiempo,
                // detenga el cronómetro,
                // muestre un cuadro de mensaje y
                // complete las respuestas.
                timer1.Stop();
                timeLabel.Text = "¡Se acabó el tiempo!";
                MessageBox.Show("No terminaste a tiempo.", "Lo siento!");
                sumar.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void answer_enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
    
}
