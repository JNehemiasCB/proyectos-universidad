using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Models
{
    internal class Venta
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
    }
}
