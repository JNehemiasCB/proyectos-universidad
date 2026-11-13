using mundialFutbol.Excepciones;
using mundialFutbol.modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace mundialFutbol
{
    public partial class Form1 : Form
    {
        private Mundial _mundial; // Declaración de la instancia del Mundial

        public Form1()
        {
            InitializeComponent();
            // Asegura que el evento de cierre esté enganchado
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar el estado del Mundial
            try
            {
                _mundial = Mundial.CargarEstado();
                CargarDatosEnListBoxes();
                MostrarEstado("Cargando datos existentes... LISTO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"FATAL: Error al cargar los datos iniciales. No se puede continuar. {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Salvar el estado del Mundial
            try
            {
                if (_mundial != null)
                {
                    _mundial.SalvarEstado();
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true; // Cancela el cierre
                MessageBox.Show($"Error al guardar los cambios: {ex.Message}\nPor favor, resuelva el problema de I/O antes de intentar salir.", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // =======================================================================
        // METODOS DE LA UI
        // =======================================================================

        private void CargarDatosEnListBoxes()
        {
            lbxEquipos.Items.Clear();
            lbxJugadores.Items.Clear();
            LimpiarDetalleJugador();

            if (_mundial.Equipos.Any())
            {
                foreach (var nombreEquipo in _mundial.Equipos.Keys)
                {
                    lbxEquipos.Items.Add(nombreEquipo);
                }
                if (lbxEquipos.Items.Count > 0)
                {
                    lbxEquipos.SelectedIndex = 0; // Dispara el evento lbxEquipos_SelectedIndexChanged
                }
            }
        }

        private void CargarJugadoresEnListBox(string nombreEquipo)
        {
            lbxJugadores.Items.Clear();
            LimpiarDetalleJugador();

            if (_mundial.Equipos.ContainsKey(nombreEquipo))
            {
                var equipo = _mundial.Equipos[nombreEquipo];

                foreach (var nombreJugador in equipo.Jugadores.Keys)
                {
                    lbxJugadores.Items.Add(nombreJugador);
                }

                // Carga la bandera del equipo
                CargarImagen(pbxBandera, equipo.RutaBandera);

                if (lbxJugadores.Items.Count > 0)
                {
                    lbxJugadores.SelectedIndex = 0; // Dispara el evento lbxJugadores_SelectedIndexChanged
                }
            }
        }

        private void CargarDetalleJugador(string nombreEquipo, string nombreJugador)
        {
            try
            {
                var jugador = _mundial.PresentarInformacionJugador(nombreEquipo, nombreJugador);

                // Llenar TextBoxes
                txtEquipo.Text = nombreEquipo;
                txtNombre.Text = jugador.Nombre;
                txtEdad.Text = jugador.Edad.ToString();
                txtAltura.Text = jugador.Altura.ToString("N2");
                txtPeso.Text = jugador.Peso.ToString("N0");
                txtSalario.Text = jugador.Salario.ToString("C"); // Formato de moneda
                txtPosicion.Text = jugador.Posicion.ToString();
                txtRutaFoto.Text = jugador.RutaFoto;

                // Cargar Foto del Jugador
                CargarImagen(pbxFotoJugador, jugador.RutaFoto);
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarDetalleJugador();
            }
        }

        private void LimpiarDetalleJugador()
        {
            txtEquipo.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtSalario.Text = "";
            txtPosicion.Text = "";
            txtRutaFoto.Text = "";
            pbxFotoJugador.Image = null;
        }

        private void CargarImagen(PictureBox pbx, string ruta)
        {
            pbx.Image = null; // Limpiar primero
            if (File.Exists(ruta))
            {
                try
                {
                    // Usar un flujo de memoria para liberar el archivo original inmediatamente
                    using (var fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                    {
                        pbx.Image = Image.FromStream(fs);
                        pbx.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (Exception)
                {
                    // Ignorar errores de carga de imagen
                }
            }
        }

        private void MostrarEstado(string mensaje)
        {
            // Implementa el control que uses para mostrar el estado (Label, StatusStrip, etc.)
            // lblStatus.Text = mensaje; 
        }

        // =======================================================================
        // MANEJO DE EVENTOS DE CONTROLES
        // =======================================================================

        private void lbxEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxEquipos.SelectedIndex != -1)
            {
                string nombreEquipoSeleccionado = lbxEquipos.SelectedItem.ToString();
                CargarJugadoresEnListBox(nombreEquipoSeleccionado);
            }
            else
            {
                lbxJugadores.Items.Clear();
                LimpiarDetalleJugador();
            }
        }

        private void lbxJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxJugadores.SelectedIndex != -1 && lbxEquipos.SelectedIndex != -1)
            {
                string nombreEquipo = lbxEquipos.SelectedItem.ToString();
                string nombreJugador = lbxJugadores.SelectedItem.ToString();
                CargarDetalleJugador(nombreEquipo, nombreJugador);
            }
            else
            {
                LimpiarDetalleJugador();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Esto dispara el evento Form1_FormClosing
        }

        // Aquí irían los demás métodos Click de los botones (btnAgregarEquipo_Click, btnCalcularNomina_Click, etc.)
        // que deben llamar a los métodos correspondientes en la instancia _mundial.
    }
}
