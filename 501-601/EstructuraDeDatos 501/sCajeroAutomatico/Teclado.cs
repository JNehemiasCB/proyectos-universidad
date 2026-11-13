using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCajeroAutomatico
{
    internal class Teclado
    {
        public int LeerEntero()
        {
            while (true)
            {
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int valor))
                    return valor;
                Console.Write("Entrada inválida. Intente de nuevo: ");
            }
        }
        public decimal LeerDecimal()
        {
            while (true)
            {
                string entrada = Console.ReadLine();
                if (decimal.TryParse(entrada, out decimal valor) && valor
                >= 0)
                    return valor;
                Console.Write("Monto inválido. Intente de nuevo: ");
            }
        }
    }
}
