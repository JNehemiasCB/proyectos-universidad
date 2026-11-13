using System;
using System.Collections.Generic;

namespace cribaDeEratostenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos al usuario el número máximo
            Console.Write("Ingrese el número máximo del rango: ");
            int max = Convert.ToInt32(Console.ReadLine());

            // Llamamos al método que aplica la criba
            int[] primos = CribaDeEratostenes(max);

            // Mostramos el resultado
            Console.WriteLine("\nNúmeros primos encontrados:");
            foreach (int p in primos)
            {
                Console.Write(p + " ");
            }
        }

        // Método que devuelve un arreglo con los números primos hasta 'max'
        static int[] CribaDeEratostenes(int max)
        {
            // Creamos un arreglo de booleanos para marcar los compuestos
            bool[] esCompuesto = new bool[max + 1];

            // Aplicamos la criba
            for (int i = 2; i * i <= max; i++)
            {
                if (!esCompuesto[i]) // si aún no está marcado
                {
                    // Marcamos los múltiplos de i
                    for (int j = i * i; j <= max; j += i)
                    {
                        esCompuesto[j] = true;
                    }
                }
            }

            // Contamos cuántos primos hay
            int contador = 0;
            for (int i = 2; i <= max; i++)
            {
                if (!esCompuesto[i]) contador++;
            }

            // Guardamos los primos en un arreglo
            int[] primos = new int[contador];
            int index = 0;
            for (int i = 2; i <= max; i++)
            {
                if (!esCompuesto[i])
                {
                    primos[index] = i;
                    index++;
                }
            }

            return primos;
        }
    }
}
