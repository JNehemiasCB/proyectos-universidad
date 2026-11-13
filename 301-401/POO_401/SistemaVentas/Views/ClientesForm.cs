using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentas.Controllers;

namespace SistemaVentas.Views
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            var ctrl = new ClientesController();
            dgvClientes.DataSource = ctrl.ObtenerClientes();
        }
    }
}
