using System;
using System.Collections.Generic;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Ordenamiento por burbuja simple");
        Console.WriteLine("-------------------------------");

        Console.Write("Ingrese la cantidad de números a ordenar: ");
        int rango = Convert.ToInt32(Console.ReadLine());
        int[] numeros = new int[rango];

        Random rand = new Random();

        Console.WriteLine("---------------------------------");

        Console.WriteLine("Números generados:");
        for (int i = 0; i < rango; i++)
        {
            numeros[i] = rand.Next(1, 100);
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();
        bool bandera = false;

        // Ordenamiento por burbuja simple
        for (int i = 0; i < rango; i++)
        {
            for (int j = 0; j < rango - 1; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    // Intercambiar
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                    bandera = true;
                }
            }
            if (!bandera)
                break;

            bandera = false;
        }
        Console.WriteLine("---------------------------------");
        // Mostrar resultado
        Console.WriteLine("Números ordenados:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}