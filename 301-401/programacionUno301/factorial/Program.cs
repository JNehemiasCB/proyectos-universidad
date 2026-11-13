using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.Write("factorial de:");
            numero = Convert.ToInt32(Console.ReadLine());
            long factorial = Factorial(numero);
            Console.WriteLine($"factorial de {numero} es:{factorial}");
        }

        static long Factorial(int n)
        {
            if (n == 0) 
                return 1;
            else
                return n * Factorial(n - 1);
            
        }
    }

}
