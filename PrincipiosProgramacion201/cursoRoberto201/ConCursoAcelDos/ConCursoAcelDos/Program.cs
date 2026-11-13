using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCursoAcelDos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int valor = 0;
            Console.WriteLine("Inserte los elementos");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("inserte el valor: {0}", i + 1);
                valor = int.Parse(Console.ReadLine());
                arr[i] = valor;
            }
            Console.WriteLine(arr[9]);
            Console.ReadKey();
        }
    }
}
