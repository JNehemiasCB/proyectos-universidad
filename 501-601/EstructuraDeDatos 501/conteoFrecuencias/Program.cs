using System;
using System.Collections.Generic;

namespace ConteoFrecuencias
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear generador de números aleatorios
            Random random = new Random();

            // Crear y llenar la lista con 20 números entre 1 y 10
            List<int> numeros = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                numeros.Add(random.Next(1, 11)); // 1 al 10
            }

            // Mostrar la lista generada
            Console.WriteLine("Lista generada:");
            Console.WriteLine(string.Join(", ", numeros));

            // Crear diccionario para contar las frecuencias
            Dictionary<int, int> frecuencias = new Dictionary<int, int>();

            // Contar frecuencias
            foreach (int numero in numeros)
            {
                if (frecuencias.ContainsKey(numero))
                {
                    frecuencias[numero]++; // ya existe, incrementa
                }
                else
                {
                    frecuencias[numero] = 1; // no existe, inicia en 1
                }
            }

            // Mostrar resultados
            Console.WriteLine("\nFrecuencia de cada número:");
            foreach (var par in frecuencias)
            {
                Console.WriteLine($"Número {par.Key} aparece {par.Value} veces.");
            }
        }
    }
}
