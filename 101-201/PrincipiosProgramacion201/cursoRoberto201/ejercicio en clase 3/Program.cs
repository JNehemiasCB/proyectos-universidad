using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_en_clase_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa una cadena de texto");
            string cadena = Console.ReadLine();
            int longCadena = 0;
            longCadena = cadena.Length;
            Console.WriteLine($"esta es la cadena original: {cadena}");
            Console.WriteLine($"la longitud de la cadena es: {longCadena}");
        }
    }
}
