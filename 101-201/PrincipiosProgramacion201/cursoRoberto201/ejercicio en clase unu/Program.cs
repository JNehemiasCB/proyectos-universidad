
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_en_clase_unu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, n3 = 0;
            string dato = "";
            int res = 0;
                Console.WriteLine("ingrese el primer numero");
                dato = Console.ReadLine();
                n1 = int.Parse(dato);
                Console.WriteLine("ingrese el segundo numero");
                dato = Console.ReadLine();
                n2 = int.Parse(dato);
                Console.WriteLine("ingrese el tercer numero");
                dato = Console.ReadLine();
                n3 = int.Parse(dato);
                res = n1 + n2 + n3;
                Console.WriteLine($"la suma de los 3 numeros es {res}");
            }
        }
    }
}
