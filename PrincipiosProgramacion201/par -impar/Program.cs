using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par__impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
         
            string dato = "";
            Console.WriteLine("introduce un numero");
            dato = Console.ReadLine();
            num = Convert.ToInt32(dato);
            if (num %2 == 0) 
            {
                Console.WriteLine("el numero es par");
            }
            else 
            {
                Console.WriteLine("el numero es impar");
                    }



        }
    }
}
