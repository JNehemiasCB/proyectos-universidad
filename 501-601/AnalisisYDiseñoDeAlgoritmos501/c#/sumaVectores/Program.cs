using System;
namespace sumaVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("longitud del Vector: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] vector1 = new int[longitud];
            int[] vector2 = new int[longitud];

            Console.WriteLine("*****Llenando el vector 1*****");

            for (int i = 0; i < longitud; i++)
            {
                Console.WriteLine($"ingresa el elemento {i+1}");
                vector1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("*****Llenando el vector 2*****");

            for (int i = 0; i < longitud; i++)
            {
                Console.WriteLine($"ingresa el elemento {i+1}");
                vector2[i] = Convert.ToInt32(Console.ReadLine());
            }
            SumaVectores suma = new SumaVectores();
            int[] resultado = suma.Sumar(vector1, vector2);
            for (int i = 0; i < resultado.Length; i++)
            {
                Console.WriteLine("El resultado de la suma es: " + resultado[i]);
            }
        }
    }
    internal class SumaVectores
    {
        public int[] Sumar(int[] vector1, int[] vector2)
        {
            int[] resultado = new int[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                resultado[i] = vector1[i] + vector2[i];
            }
            return resultado;
        }
    }
}