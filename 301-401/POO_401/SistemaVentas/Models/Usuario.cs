using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Models
{
    internal class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
    }
}
