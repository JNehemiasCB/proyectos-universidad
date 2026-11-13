using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_en_clase_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int nemp;
            double nvosueldo;
            double sueldo;
            Console.WriteLine("Cuantos empleados??");
            nemp = int.Parse(Console.ReadLine());
            for ( i = 1; i < nemp; i++)
            {
                Console.WriteLine($"Empleado {i} insertar sueldo");
                sueldo = double.Parse(Console.ReadLine());
                if ( sueldo <1000)
                {
                    nvosueldo = sueldo * 1.15;
                    Console.WriteLine($"nuevo sueldo Empleado {i} = {nvosueldo}");
                }
                else
                {
                    nvosueldo = sueldo * 1.875;
                    Console.WriteLine($"El nuevo sueldo del empleado {i} = {nvosueldo}");
                }
            }
        }
    }
}
