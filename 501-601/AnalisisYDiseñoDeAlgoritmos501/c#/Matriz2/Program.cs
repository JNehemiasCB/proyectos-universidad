using System;

namespace Matriz2
{
    internal class Program
    {
        // Método para verificar si un número es primo
        static bool EsPrimo(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for(int i = 3; i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de filas y columnas de la matriz");
            int Fil = Convert.ToInt32(Console.ReadLine());
            int Col = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[Fil, Col];
            int[,] matrizResultado = new int[Fil, Col];
            Random rand = new Random();

            // Llenar y mostrar la matriz original
            Console.WriteLine("\nMatriz original:");
            for (int i = 0; i < Fil; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }

            // Crear la matriz resultado según las reglas
            for (int i = 0; i < Fil; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    int num = matriz[i, j];
                    if (EsPrimo(num))
                    {
                        matrizResultado[i, j] = 0;       // primo → 0
                    }
                    else if (num % 2 == 0)
                    {
                        matrizResultado[i, j] = 1;       // par no primo → 1
                    }
                }
            }

            // Mostrar la matriz resultado
            Console.WriteLine("\nMatriz resultado:");
            Console.WriteLine("0 = primo, 1 = par no primo, -1 = ni primo ni par");
            for (int i = 0; i < Fil; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    Console.Write("[" + matrizResultado[i, j]+ "]");
                }
                Console.WriteLine();
            }

            Console.ReadKey(); // Para que no se cierre la consola
        }
    }
}