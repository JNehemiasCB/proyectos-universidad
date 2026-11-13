using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Models
{
    internal class Inventario
    {
        public int IdInventario { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
        public string Observaciones { get; set; }
    }
}
