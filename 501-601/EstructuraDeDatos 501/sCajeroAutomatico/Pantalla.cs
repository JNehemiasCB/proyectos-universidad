using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCajeroAutomatico
{
    internal class Pantalla
    {
        public void Mostrar(string texto) => Console.Write(texto);
        public void MostrarLinea(string texto = "") => Console.WriteLine
        (texto);
        public void MostrarMonto(decimal monto) => Console.WriteLine($"${monto:N2}");
    }
}
