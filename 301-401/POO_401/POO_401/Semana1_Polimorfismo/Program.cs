using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sobrecarga de metodos
            var calcu = new Calculadora();
            Console.WriteLine(calcu.Sumar(5, 6));
            Console.WriteLine(calcu.Sumar(7.8, 4.3));
            Console.WriteLine(calcu.Sumar(6, 7, 8));
        }
    }
}
