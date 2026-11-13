using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cribaDeEratostenesV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cuantos quieres?");
            int cuantos = int.Parse(Console.ReadLine());

            bool[] esPrimo = new bool[cuantos + 1];
            int i = 0;
            while(i <= cuantos)
            {
                esPrimo[i] = true;
                i++;
            }

            int posicion = 2;
            while (posicion < cuantos)
            {
                if (esPrimo[posicion])
                {
                    int n = 2;
                    while(n* posicion <= cuantos)
                    {
                        esPrimo[n * posicion] = false;
                        n++;
                    }
                }
                posicion++;
            }

            i = 2;
            while(i <= cuantos)
            {
                if (esPrimo[i])
                {
                    Console.Write(i + ", ");
                }
                i++;
            }
        }
    }
}
