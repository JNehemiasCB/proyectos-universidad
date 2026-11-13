using System;

namespace Sumadematrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Random = new Random();

            Console.Write("Ingresa el numero de filas: ");
            int fil = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el numero de columnas: ");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] M1 = new int[fil, col];
            int[,] M2 = new int[fil, col];
            int[,] MR = new int[fil, col];

            Console.WriteLine("\nMatriz 1");
            for (int i = 0; i < fil; i++)
            {
                for (int j = 0; j < col; j++)
                {                
                    M1[i, j] = Random.Next(1, 101);
                    Console.Write(M1[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("\nMatriz 2");
            for (int i = 0; i < fil; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    M2[i, j] = Random.Next(1, 101);
                    Console.Write(M2[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("\nSuma de las matrices: ");
            for (int i = 0; i < fil; i++)
            {
                for(int j = 0;j < col; j++)
                {
                    MR[i, j] = M1[i,j] + M2[i,j];
                    Console.Write(MR[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
