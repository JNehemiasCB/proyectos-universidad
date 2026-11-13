using System;

namespace sumaVectores2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("ingresa el tamaño de los vectores");
            int Longitud = int.Parse(Console.ReadLine());

            int[] vector1 = new int[Longitud];   
            int [] vector2 = new int[Longitud]; 
            int [] Suma_De_Vectores = new int[Longitud];

            for (int i = 0; i < Longitud; i++)
            {
                Console.WriteLine($"V1 [{i}]");
                vector1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"V2 [{i}]");
                vector2[i] = int.Parse(Console.ReadLine());

                Suma_De_Vectores[i] = vector1[i] + vector2[i];

            }
            Console.WriteLine("El resultado de la suma de los vectores es: ");
            Console.WriteLine("[" + string.Join(", ", Suma_De_Vectores) + "]");

        }
    }
}
