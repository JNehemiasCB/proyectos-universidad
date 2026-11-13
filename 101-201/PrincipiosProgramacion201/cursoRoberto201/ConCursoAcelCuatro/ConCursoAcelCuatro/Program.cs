using System;
namespace ConCursoAcelCuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena = "ahora la zzz duda ahora la zzz duda surge cuando fff tengo un texto con promedio de 10.000 xxxxx caracteres o mas es decir deseo contar";
            int longitudCad = 0;
            longitudCad = cadena.Length;
            Console.WriteLine("Esta es la cadena original:" + cadena);
            Console.WriteLine("La longitud de la cádena es: {0}", longitudCad);
            Console.ReadKey();
        }
    }
}
