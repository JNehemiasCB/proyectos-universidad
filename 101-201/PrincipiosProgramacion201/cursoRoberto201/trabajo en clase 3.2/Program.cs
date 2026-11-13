using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_en_clase_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bandera = true;
            int numero = -1;
            int contarCif = 0;
            string sino = "";
            while (bandera)
            {
                Console.WriteLine("inserte un numero");
                numero = Convert.ToInt32(Console.ReadLine());
                contarCif = 1;
                while ( numero >= 10)
                {
                    numero = numero / 10;
                    contarCif++;
                }
                Console.WriteLine("el numero de cifras es :{0}", contarCif);
                Console.WriteLine("Desea continuar? (S/N");
                if (sino == "S" || sino == "s")
                    bandera = true;
                else
                    bandera = false;
            }
        }// fin
    }
}
