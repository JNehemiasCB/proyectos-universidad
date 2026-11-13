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
    public partial class FrmProyectos : Form
    {
        string connectionString = "server=localhost;user=root;password=201105;database=proyectos_db;";

        public FrmProyectos()
        {
            InitializeComponent();
            cargarProyectos();
            
        }

        private void cargarProyectos()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Proyectos";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvProyectos.DataSource = table;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                
                string getIdQuery = @"
            SELECT MIN(t1.id + 1) AS nuevoId
            FROM Proyectos t1
            LEFT JOIN Proyectos t2 ON t1.id + 1 = t2.id
            WHERE t2.id IS NULL";

                int nuevoId = 1;

                MySqlCommand getIdCmd = new MySqlCommand(getIdQuery, conn);
                conn.Open();
                object result = getIdCmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                    nuevoId = Convert.ToInt32(result);

                
                string query = @"INSERT INTO Proyectos (id, nombre, descripcion, fecha_inicio, fecha_fin, estado)
                         VALUES (@id, @nombre, @descripcion, @inicio, @fin, @estado)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", nuevoId);
                cmd.Parameters.AddWithValue("@nombre", txtNombreProyecto.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcionProyecto.Text);
                cmd.Parameters.AddWithValue("@inicio", dtpFechaInicio.Value.Date);
                cmd.Parameters.AddWithValue("@fin", dtpFechaFin.Value.Date);
                cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Proyecto guardado.");
                cargarProyectos();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProyectos.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvProyectos.SelectedRows[0].Cells["id"].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM Proyectos WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Proyecto eliminado.");
                cargarProyectos();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombreProyecto.Clear();
            txtDescripcionProyecto.Clear();
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            cmbEstado.SelectedIndex = 0;
        }

        private void btnAbrirFormulario_Click(object sender, EventArgs e)
        {
            FrmTareas formTareas = new FrmTareas();
            formTareas.Show();
            this.Hide();
        }


        private void calcularProgreso(int proyectoId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                            COUNT(*) AS total, 
                            SUM(CASE WHEN estado = 'Completada' THEN 1 ELSE 0 END) AS completadas
                         FROM Tareas
                         WHERE proyecto_id = @proyectoId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@proyectoId", proyectoId);
                conn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int total = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    int completadas = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);

                    int porcentaje = (total == 0) ? 0 : (completadas * 100 / total);
                    pgbProgreso.Value = porcentaje;
                    lblProgreso.Text = porcentaje + "% completado";
                }
                conn.Close();
            }
        }

        private void dgvProyectos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProyectos.SelectedRows.Count == 0) return;

            int idProyecto = Convert.ToInt32(dgvProyectos.SelectedRows[0].Cells["id"].Value);
            calcularProgreso(idProyecto);
        }

        private void FrmProyectos_Load(object sender, EventArgs e)
        {

        }
    }
}