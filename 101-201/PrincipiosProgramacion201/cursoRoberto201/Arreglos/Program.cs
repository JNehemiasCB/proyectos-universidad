using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("defina el rango del arreglo");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arreglo = new int[n];
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("ingrese los numeros");
                int valor = Convert.ToInt32(Console.ReadLine());
                arreglo[i] = valor;
            }
            Console.WriteLine("arreglo desordenado");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            Console.WriteLine("arreglo ordenado de forma acendente");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Array.Sort(arreglo);
                Console.WriteLine(arreglo[i]);
            }
            int indice = 0;
            int numerobuscado = 0;
            Console.WriteLine("ingresa el numero que desea buscar");
            numerobuscado = Convert.ToInt32(Console.ReadLine());
            indice = Array.IndexOf(arreglo, numerobuscado); //IndexOf localiza ciertos valores dentro de un arreglo
            if (indice != -1) //Se pone la condicion 
            {
                Console.WriteLine($"el numero {numerobuscado} se encuentra en el indice {indice}");
            }
            else
            {
                Console.WriteLine($"el numero {numerobuscado} no se encuentra en el arreglo");
            }
        }
    }
}