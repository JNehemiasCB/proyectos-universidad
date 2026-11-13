using System;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("¿Cuántos términos de la serie de Fibonacci quieres? ");
        int n = Convert.ToInt32(Console.ReadLine());

        BigInteger a = 0, b = 1, c;

        Console.WriteLine("Serie de Fibonacci:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }

}
