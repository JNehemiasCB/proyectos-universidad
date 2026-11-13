using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCajeroAutomatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cajero = new CajeroAutomatico();
            cajero.Ejecutar();
        }
    }
}
