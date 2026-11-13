using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Administración_de_Proyectos
{
    public partial class FrmTareas : Form
    {
        string connectionString = "server=localhost;user=root;password=201105;database=proyectos_db;";
        public FrmTareas()
        {
            InitializeComponent();
            cargarTareas();
            cargarMiembros();
        }

        private void btnAbrirFormulario_Click(object sender, EventArgs e)
        {
            FrmProyectos formProyectos = new FrmProyectos();
            formProyectos.Show();
            this.Hide();
        }

        private void cargarTareas()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tareas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvTareas.DataSource = table;
            }
        }

        private void cargarMiembros()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT id, nombre FROM MiembrosEquipo";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                cmbAsignadoA.Items.Clear();
                while (reader.Read())
                {
                    cmbAsignadoA.Items.Add(new ComboboxItem
                    {
                        Text = reader["nombre"].ToString(),
                        Value = reader["id"]
                    });
                }
                conn.Close();
            }
        }

        private int ObtenerNuevoIdTarea()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
            SELECT COALESCE(MIN(t1.id + 1), 1) AS nuevoId
            FROM Tareas t1
            LEFT JOIN Tareas t2 ON t1.id + 1 = t2.id
            WHERE t2.id IS NULL";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                return (result != DBNull.Value && result != null) ? Convert.ToInt32(result) : 1;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbAsignadoA.SelectedItem == null) return;
            var miembro = (ComboboxItem)cmbAsignadoA.SelectedItem;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                int nuevoId = ObtenerNuevoIdTarea();

                string query = @"INSERT INTO Tareas (id, proyecto_id, titulo, descripcion, fecha_vencimiento, prioridad, estado, asignado_a_miembro_id)
                         VALUES (@id, 1, @titulo, @descripcion, @fecha, @prioridad, @estado, @miembro)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", nuevoId);
                cmd.Parameters.AddWithValue("@titulo", txtTituloTarea.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcionTarea.Text); // Ahora se utiliza correctamente
                cmd.Parameters.AddWithValue("@fecha", dtpFechaFinTarea.Value.Date);
                cmd.Parameters.AddWithValue("@prioridad", cmbPrioridad.Text);
                cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);
                cmd.Parameters.AddWithValue("@miembro", miembro.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tarea agregada.");
                cargarTareas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvTareas.SelectedRows[0].Cells["id"].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM Tareas WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tarea eliminada.");
                cargarTareas();
            }
        }

        private class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una tarea para editar.");
                return;
            }

            if (cmbAsignadoA.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un miembro del equipo.");
                return;
            }

            int id = Convert.ToInt32(dgvTareas.SelectedRows[0].Cells["id"].Value);
            var miembro = (ComboboxItem)cmbAsignadoA.SelectedItem;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"UPDATE Tareas SET
            titulo = @titulo,
            descripcion = @descripcion,
            fecha_vencimiento = @fecha,
            prioridad = @prioridad,
            estado = @estado,
            asignado_a_miembro_id = @miembro
            WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@titulo", txtTituloTarea.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcionTarea.Text);
                cmd.Parameters.AddWithValue("@fecha", dtpFechaFinTarea.Value.Date);
                cmd.Parameters.AddWithValue("@prioridad", cmbPrioridad.Text);
                cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);
                cmd.Parameters.AddWithValue("@miembro", miembro.Value);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Tarea actualizada.");
                cargarTareas();
            }
        }

    }
}