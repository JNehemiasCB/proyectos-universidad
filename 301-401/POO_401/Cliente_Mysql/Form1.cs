using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cliente_Mysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string servidor = txtServidor.Text;
            string puerto = txtPuerto.Text;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            string bd = txtBd.Text;

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id=" + usuario + "; Password=" + password;
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null;
            string data = "";

            try
            {
                string consulta = "SHOW DATABASES";
                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Connection = conexionBD;
                conexionBD.Open();
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    data += reader.GetString(0) + "\n";
                }

                MessageBox.Show(data);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }


    }
}
