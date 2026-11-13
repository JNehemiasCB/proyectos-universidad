using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_en_clase_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int[] arr = new int[10];
            int valor = 0;
            Console.WriteLine("inserte los elementos");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"inserte el valor del indice {i+1}");
                valor = int.Parse(Console.ReadLine());
                arr[i] = valor;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();


                
        }
    }
}
