using System;
namespace ConInvertirNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int unidad, decena, invertido, numero;
            string lectura;
            Console.WriteLine("Ingrese un número de 2 cifras");
            lectura= Console.ReadLine();
            numero=Convert.ToInt32(lectura);
            unidad = numero % 10;
            decena=numero / 10;
            invertido=unidad*10 + decena;
            Console.WriteLine("El n umero invertido es: " + invertido);
            Console.WriteLine("Pulse una tecla para continuar...");
           Console.ReadKey();
        }
    }
}
