using System;
namespace ConCursoAcelCinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int nemp;
            double nvosueldo;
            double sueldo;
            Console.WriteLine("Cuantos empleado?");
            nemp = int.Parse(Console.ReadLine());
            for (i = 1; i <= nemp; i++)
            {
                Console.WriteLine("Empleado "+i + " insertar sueldo");
                sueldo = Double.Parse(Console.ReadLine());
                if (sueldo < 1000)
                {
                    nvosueldo = sueldo * 1.15;
                    Console.WriteLine("Nuevo sueldo Empleado "+i + " "+nvosueldo);
                }
                else
                {
                    nvosueldo = sueldo * 1.075;
                    Console.WriteLine("Nuevo sueldo Empleado "+i + " "+nvosueldo);
                }
            }
            Console.ReadKey();
        } //Fin del método main()
    }
}
