using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo_unidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] idEmpleados; //inicializamos el arreglo
            idEmpleados = new int[4]; //indice de 4
            idEmpleados[0] = 1;
            idEmpleados[1] = 2;
            idEmpleados[2] = 3;
            idEmpleados[3] = 4;

            string[] nombreEmpleado = { "nehemias", "ramses", "alexandra", "said" };





            for (int i = 0; i < idEmpleados.Length; i++)
            {
                Console.WriteLine($"ID: {idEmpleados[i]}, Name: {nombreEmpleado[i]}");
            }

        }
    }
}
