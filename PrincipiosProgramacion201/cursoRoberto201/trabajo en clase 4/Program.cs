
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_en_clase_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, primero = 0, d = 0, n = 0;

            bool bandera = true;
            string sino = "";
           
            while (bandera)
            {
                Console.WriteLine("inserta un numero");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("inserta el primer termino");
                primero = int.Parse(Console.ReadLine());
                Console.WriteLine("inserta la diferencia");
                d = int.Parse(Console.ReadLine());
                while (n >= 0)
                {
                    suma += primero;
                    primero += d;
                    n -= 1;
                }
                Console.WriteLine("la suma es {0}", suma);
                Console.Read();
                Console.Clear();
                Console.WriteLine("desea continuar? (S/N)");
                sino = Console.ReadLine();
                if (sino == "S" || sino == "s")
                {
                    bandera = true;
                }
                else bandera = false;
            }
        }
    }
}
