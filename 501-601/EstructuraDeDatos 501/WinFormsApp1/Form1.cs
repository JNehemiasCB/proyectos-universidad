using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Declaraciones de Variables Globales (Arreglo y Random)
        private int[] _arr = new int[0];
        private Random _rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            // Llama a un método para mostrar el arreglo vacío al inicio
            MostrarArregloEnListBox();
        }

        // ==========================================================
        // MÉTODOS DE UTILIDAD
        // ==========================================================

        private void MostrarArregloEnListBox()
        {
            lstArreglo.Items.Clear();
            if (_arr.Length == 0)
            {
                lstArreglo.Items.Add("(Arreglo vacío)");
                return;
            }

            for (int i = 0; i < _arr.Length; i++)
            {
                // Muestra el índice y el valor
                lstArreglo.Items.Add($"[{i,3}]: {_arr[i]}");
            }
        }

        private void SetMensaje(string mensaje)
        {
            lblMensajes.Text = mensaje;
        }

        private void LimpiarPanelVisualizacion()
        {
            pnlVisualizacion.Controls.Clear();
        }


        // ==========================================================
        // MANEJADORES DE EVENTOS
        // ==========================================================

        private void btnCrearAleatorio_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTamanoN.Text, out int n) && n >= 0)
            {
                _arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    _arr[i] = _rnd.Next(0, 101); // 0..100
                }
                SetMensaje($"Arreglo creado con {n} elementos aleatorios.");
            }
            else
            {
                SetMensaje("Error: Tamaño N inválido.");
            }
            MostrarArregloEnListBox();
        }

        private void btnCargarArreglo_Click(object sender, EventArgs e)
        {
            try
            {
                string[] valores = txtCargarValores.Text.Split(',');
                var nuevaLista = new List<int>();

                foreach (string val in valores)
                {
                    // Ignora espacios en blanco resultantes de comas vacías (ej: "1,,2")
                    if (string.IsNullOrWhiteSpace(val.Trim())) continue;

                    if (int.TryParse(val.Trim(), out int num))
                    {
                        nuevaLista.Add(num);
                    }
                    else
                    {
                        throw new FormatException($"El valor '{val.Trim()}' no es un número entero válido.");
                    }
                }
                _arr = nuevaLista.ToArray();
                SetMensaje($"Arreglo cargado con {_arr.Length} elementos.");
            }
            catch (Exception ex)
            {
                SetMensaje($"Error al cargar: {ex.Message}");
            }
            MostrarArregloEnListBox();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (_arr.Length == 0)
            {
                SetMensaje("Error: El arreglo está vacío. Primero crea el arreglo.");
                return;
            }
            Array.Sort(_arr);
            SetMensaje("Arreglo ordenado ascendentemente.");
            MostrarArregloEnListBox();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (_arr.Length == 0)
            {
                SetMensaje("Error: Primero crea el arreglo.");
                lblResultadoBusqueda.Text = "";
                return;
            }

            // BinarySearch requiere el arreglo ordenado. Lo ordenamos para asegurar.
            Array.Sort(_arr);

            if (int.TryParse(txtValorBuscar.Text, out int val))
            {
                int idx = Array.BinarySearch(_arr, val);
                if (idx >= 0)
                {
                    lblResultadoBusqueda.Text = $"Encontrado en índice: {idx}";
                    SetMensaje($"Valor {val} encontrado.");
                }
                else
                {
                    lblResultadoBusqueda.Text = "No encontrado.";
                    SetMensaje($"Valor {val} no encontrado.");
                }
            }
            else
            {
                lblResultadoBusqueda.Text = "Valor inválido.";
                SetMensaje("Error: Valor de búsqueda inválido.");
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            if (_arr.Length == 0)
            {
                SetMensaje("Error: Arreglo vacío. No se pueden calcular estadísticas.");
                lblMinimo.Text = "Mínimo: -";
                lblMaximo.Text = "Máximo: -";
                lblSuma.Text = "Suma: -";
                lblPromedio.Text = "Promedio: -";
                lblMediana.Text = "Mediana: -";
                return;
            }

            int min = _arr.Min();
            int max = _arr.Max();
            long sum = _arr.Sum(); // Usar long para evitar overflow en sumas grandes
            double avg = _arr.Average();

            // Cálculo de la Mediana: requiere el arreglo ordenado
            int[] sortedArr = (int[])_arr.Clone(); // Clonar para no modificar el arreglo original si no está ordenado
            Array.Sort(sortedArr);
            double mediana;
            int n = sortedArr.Length;
            if (n % 2 == 1)
            {
                mediana = sortedArr[n / 2];
            }
            else
            {
                mediana = (sortedArr[n / 2 - 1] + sortedArr[n / 2]) / 2.0;
            }

            lblMinimo.Text = $"Mínimo: {min}";
            lblMaximo.Text = $"Máximo: {max}";
            lblSuma.Text = $"Suma: {sum}";
            lblPromedio.Text = $"Promedio: {avg:F2}";
            lblMediana.Text = $"Mediana: {mediana:F2}";
            SetMensaje("Estadísticas calculadas correctamente.");
        }

        private void btnRedimensionar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNuevoTamano.Text, out int nuevo) && nuevo >= 0)
            {
                Array.Resize(ref _arr, nuevo);
                SetMensaje($"Arreglo redimensionado a {nuevo} elementos.");
            }
            else
            {
                SetMensaje("Error: Tamaño de redimensión inválido.");
            }
            MostrarArregloEnListBox();
        }

        private void btnInvertirDistinct_Click(object sender, EventArgs e)
        {
            if (_arr.Length == 0)
            {
                SetMensaje("Error: Arreglo vacío.");
                return;
            }

            lstArreglo.Items.Clear();
            lstArreglo.Items.Add("--- ARREGLO INVERTIDO ---");

            // Usa Linq para invertir (simulando ArrayUtils.Invertir)
            int[] invertido = _arr.Reverse().ToArray();
            lstArreglo.Items.Add(string.Join(", ", invertido));

            lstArreglo.Items.Add("");
            lstArreglo.Items.Add("--- ARREGLO SIN DUPLICADOS (DISTINCT) ---");

            int[] sinRep = _arr.Distinct().ToArray();
            lstArreglo.Items.Add(string.Join(", ", sinRep));

            SetMensaje("Arreglo invertido y sin duplicados mostrados en el ListBox.");
        }

        private void btnEjemplo2D_Click(object sender, EventArgs e)
        {
            // Lógica de la Opción 7: Ejemplo2D() - Visualización
            LimpiarPanelVisualizacion();
            SetMensaje("Generando Tabla de Multiplicar Parcial (Ejemplo 2D)...");

            int filas = 5;
            int cols = 5;

            int[,] tabla = new int[filas, cols];
            string output = "Tabla de Multiplicar Parcial:\n\n";

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    tabla[i, j] = (i + 1) * (j + 1);
                    output += $"{tabla[i, j],5}"; // Espaciado para alineación
                }
                output += "\r\n"; // Usa \r\n para salto de línea en TextBox de WinForms
            }

            TextBox txtTabla = new TextBox();
            txtTabla.Multiline = true;
            txtTabla.ReadOnly = true;
            txtTabla.Font = new Font("Consolas", 10);
            txtTabla.Text = output;
            txtTabla.Dock = DockStyle.Fill;

            pnlVisualizacion.Controls.Add(txtTabla);
            SetMensaje("Tabla 2D generada y visualizada en el Panel.");
        }

        private void btnEjemploJagged_Click(object sender, EventArgs e)
        {
            // Lógica de la Opción 8: EjemploJagged() - Visualización
            LimpiarPanelVisualizacion();
            SetMensaje("Generando Arreglo Dentado (Triángulo de Números)...");

            int n = 7; // N niveles (triángulo)

            int[][] jagged = new int[n][];
            string output = "Arreglo Dentado (Triángulo):\n\n";

            for (int i = 0; i < n; i++)
            {
                jagged[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    jagged[i][j] = j + 1;
                }
                // Une los números de cada fila con un espacio y agrega salto de línea
                output += string.Join("  ", jagged[i]) + "\r\n";
            }

            TextBox txtTriangulo = new TextBox();
            txtTriangulo.Multiline = true;
            txtTriangulo.ReadOnly = true;
            txtTriangulo.Font = new Font("Consolas", 10);
            txtTriangulo.Text = output;
            txtTriangulo.Dock = DockStyle.Fill;

            pnlVisualizacion.Controls.Add(txtTriangulo);
            SetMensaje("Arreglo dentado generado y visualizado en el Panel.");
        }
    }
}