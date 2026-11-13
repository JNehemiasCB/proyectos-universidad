using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciudad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ciudad = "", nombre = "";
            Console.WriteLine("ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingresa la ciudad");
            ciudad = Console.ReadLine();
            Console.WriteLine($"hola {nombre} bienvenido a {ciudad}");
        }
    }
}
