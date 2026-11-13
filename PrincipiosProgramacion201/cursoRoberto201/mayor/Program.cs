using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            string dato = "";
            Console.WriteLine("ingresa el primer numero");
            dato = Console.ReadLine();
            n1 = Convert.ToInt32(dato);
            Console.WriteLine("ingresa el segundo numero");
            dato = Console.ReadLine();
            n2 = Convert.ToInt32(dato);
            if (n1 > n2)
            {
                Console.WriteLine("el primer numero es el mayor");
            }
            else
            {
                Console.WriteLine("el segundo numero es el mayor");
            }

        }
    }
}
