using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCursoAcelTres
{
    internal class Program
    {
        // Este programa nos va a permitir 
        //invertir las cifras de un número de
        // dos digitos
        static void Main(string[] args)
        {
            int numero, unidades, decenas, resultado;
            Console.WriteLine("Inserta un número de dos cifras");
            numero = int.Parse(Console.ReadLine());
            unidades = numero % 10;
            decenas = numero / 10;
            resultado = unidades * 10 + decenas;
            Console.WriteLine("El número invertido es el siguiente: {0}", resultado);
            Console.ReadKey();
        } //Fin del método main()        
    }//Fin de la clase
} //fin del namespace
