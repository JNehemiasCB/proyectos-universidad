using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WF_ManejadorMuestras
{
    public partial class Form1 : Form
    {
        private Muestra muestra;
        private MuestraOrdenada muestraOrd;
        private Stopwatch reloj = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            DesactivarBotones();
        }

        private void DesactivarBotones()
        {
            btnBurbuja.Enabled = false;
            btnSeleccion.Enabled = false;
            btnInsercion.Enabled = false;

            btnSecuencial.Enabled = false;
            btnBinaria.Enabled = false;

            btnEnRango.Enabled = false;
            btnOcurrencias.Enabled = false;
            btnDistintos.Enabled = false;
            btnMasFrecuente.Enabled = false;
        }

        private void ActivarBotonesOrdenamiento()
        {
            btnBurbuja.Enabled = true;
            btnSeleccion.Enabled = true;
            btnInsercion.Enabled = true;
        }

        private void ActivarBotonesBusqueda()
        {
            btnSecuencial.Enabled = true;
            btnBinaria.Enabled = true;

            btnEnRango.Enabled = true;
            btnOcurrencias.Enabled = true;
            btnDistintos.Enabled = true;
            btnMasFrecuente.Enabled = true;
        }

        //Nueva muestra
        private void btnNuevaMuestra_Click(object sender, EventArgs e)
        {
            try
            {
                int tam = int.Parse(txtTamano.Text);
                int lim = int.Parse(txtLimite.Text);

                muestra = new Muestra(tam, lim);
                muestra.GeneraValores();

                txtMinimo.Text = muestra.DarMínimo().ToString();
                txtMaximo.Text = muestra.DarMáximo().ToString();
                txtPromedio.Text = muestra.DarPromedio().ToString("F2");

                listBox1.DataSource = muestra.ObtenerValores().ToList();

                ActivarBotonesOrdenamiento();

                btnSecuencial.Enabled = false;
                btnBinaria.Enabled = false;
                btnEnRango.Enabled = false;
                btnOcurrencias.Enabled = false;
                btnDistintos.Enabled = false;
                btnMasFrecuente.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Verifica que los campos Tamaño y Límite sean válidos.", "Error");
            }
        }

        //Ordenamiento Burbuja
        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            if (muestra == null) return;

            reloj.Restart();
            muestraOrd = muestra.OrdenaBurbuja();
            reloj.Stop();

            listBox1.DataSource = muestraOrd.ObtenerValores().ToList();
            txtTiempoBurbuja.Text = $"{reloj.ElapsedMilliseconds} ms";

            ActivarBotonesBusqueda();
        }

        //Ordenamiento Selección
        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if (muestra == null) return;

            reloj.Restart();
            muestraOrd = muestra.OrdenaSelección();
            reloj.Stop();

            listBox1.DataSource = muestraOrd.ObtenerValores().ToList();
            txtTiempoSeleccion.Text = $"{reloj.ElapsedMilliseconds} ms";

            ActivarBotonesBusqueda();
        }

        //Ordenamiento Inserción
        private void btnInsercion_Click(object sender, EventArgs e)
        {
            if (muestra == null) return;

            reloj.Restart();
            muestraOrd = muestra.OrdenaInserción();
            reloj.Stop();

            listBox1.DataSource = muestraOrd.ObtenerValores().ToList();
            txtTiempoInsercion.Text = $"{reloj.ElapsedMilliseconds} ms";

            ActivarBotonesBusqueda();
        }

        private void btnSecuencial_Click(object sender, EventArgs e)
        {
            if (muestraOrd == null) return;

            try
            {
                int valor = int.Parse(txtValorBuscar.Text);

                reloj.Restart();
                bool encontrado = muestraOrd.busquedaSecuencial(valor);
                reloj.Stop();

                txtTiempoSecuencial.Text = $"{reloj.ElapsedMilliseconds} ms";

                double promedio = muestraOrd.tiempoPromedioBusquedaSecuencial();

                MessageBox.Show(
                    $"{(encontrado ? "Valor encontrado" : "Valor no encontrado")}\n\n" +
                    $"Tiempo individual: {reloj.ElapsedMilliseconds} ms\n" +
                    $"Tiempo promedio (1..{muestraOrd.Limite}): {promedio:F6} ms",
                    "Búsqueda Secuencial"
                );
            }
            catch
            {
                MessageBox.Show("Introduce un valor válido para buscar.");
            }
        }

        private void btnBinaria_Click(object sender, EventArgs e)
        {
            if (muestraOrd == null) return;

            try
            {
                int valor = int.Parse(txtValorBuscar.Text);

                reloj.Restart();
                bool encontrado = muestraOrd.busquedaBinaria(valor);
                reloj.Stop();

                txtTiempoBinaria.Text = $"{reloj.ElapsedMilliseconds} ms";

                double promedio = muestraOrd.tiempoPromedioBusquedaBinaria();

                MessageBox.Show(
                    $"{(encontrado ? "Valor encontrado" : "Valor no encontrado")}\n\n" +
                    $"Tiempo individual: {reloj.ElapsedMilliseconds} ms\n" +
                    $"Tiempo promedio (1..{muestraOrd.Limite}): {promedio:F6} ms",
                    "Búsqueda Binaria"
                );
            }
            catch
            {
                MessageBox.Show("Introduce un valor válido para buscar.");
            }
        }

        private void btnEnRango_Click(object sender, EventArgs e)
        {
            if (muestraOrd == null) return;

            try
            {
                int inf = int.Parse(txtInferior.Text);
                int sup = int.Parse(txtSuperior.Text);

                int cantidad = muestraOrd.contarElementosEnRango(inf, sup);
                txtElementosRango.Text = cantidad.ToString();
            }
            catch
            {
                MessageBox.Show("Verifica los valores de rango (Inf y Sup).");
            }
        }

        private void btnOcurrencias_Click(object sender, EventArgs e)
        {
            if (muestraOrd == null) return;

            try
            {
                int valor = int.Parse(txtValorOcurrencia.Text);
                int cantidad = muestraOrd.cuentaOcurrencias(valor);
                txtOcurrencias.Text = cantidad.ToString();
            }
            catch
            {
                MessageBox.Show("Introduce un valor válido para contar ocurrencias.");
            }
        }

        //Valores distintos
        private void btnDistintos_Click(object sender, EventArgs e)
        {
            if (muestraOrd == null) return;

            int distintos = muestraOrd.contarValoresDistintos();
            txtDistintos.Text = distintos.ToString();
        }


        private void btnMasFrecuente_Click(object sender, EventArgs e)
        {
            if (muestraOrd == null) return;

            int valor = muestraOrd.darValorMasFrecuente();
            txtMasFrecuente.Text = valor.ToString();
        }
    }
}