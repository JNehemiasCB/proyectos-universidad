using System;
namespace ConCursoAcelSeis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limite;
            // Obtener la lista de números a evaluar
            limite = 16;
            bool[] numeros = new bool[limite];
            // Inicializar la lista de números como verdaderos
            for (int i = 2; i <= limite - 1; ++i)
            {
                numeros[i] = true;
            }
            // Hacer 2 el primer número primo
            numeros[2] = true;
            // Recorrer los números y para cada uno
            for (int n = 2; n <= limite - 1; n++)
            {
                // Si es primo, recorrer los múltiplos y marcarlos 
                //como no primo
                if (numeros[n] == true)
                {
                    for (int i = (n * n); i <= limite - 1; i += n)
                    {
                        numeros[i] = false;
                    }
                }
            }
            // Mostrar la lista de números primos
            Console.WriteLine("Primos:");
            for (int n = 2; n <= limite - 1; n++)
            {
                if (numeros[n] == true)
                {
                    Console.WriteLine(n);
                }
            }
            Console.ReadKey();
        }//Fin del método main()
    }
}
