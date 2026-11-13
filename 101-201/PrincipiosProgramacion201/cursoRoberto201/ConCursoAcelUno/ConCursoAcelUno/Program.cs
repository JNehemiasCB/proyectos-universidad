using System;
namespace ConCursoAcelUno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b=100, d=4, e=5;
            bool algo = false, otro=true;
            int caracter;
            caracter = Console.Read();
            Console.WriteLine(caracter);
            Console.WriteLine((char)caracter);
            Console.WriteLine("----------------");
            var rand = new Random();
            var condition = rand.NextDouble() > 0.5;
            var x = condition ? 12 : (int?)null;
            Console.WriteLine(x);
            Console.WriteLine(condition);
            Console.WriteLine("----------------");
            int respuestas = algo ? b : otro ? d : e;
            Console.WriteLine(respuestas);
            Console.WriteLine("Resultados lógicos: {0} {1}",algo, otro);
            Console.ReadKey(true);
        }
    }
}
