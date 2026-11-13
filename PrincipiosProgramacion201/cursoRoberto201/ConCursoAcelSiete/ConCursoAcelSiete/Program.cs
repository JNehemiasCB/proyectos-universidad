using System;
namespace ConCursoAcelSiete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acum, numero, resultado;
            //double resultado;
            acum = 0;
            Console.WriteLine("Ingrese cuántos números desea consultar:");
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                acum = 0;
                for (int j = 1; j <= i; j++)
                {
                    resultado = i / j;
                    if (resultado==0) // - Math.Truncate(resultado) == 0)
                    {
                        acum = acum + 1;
                    }
                }
                if (acum == 2)
                {
                    Console.WriteLine(i + " es un número primo.");
                }

            }
            Console.ReadKey();
        } //Fin del método main()
    }
}
