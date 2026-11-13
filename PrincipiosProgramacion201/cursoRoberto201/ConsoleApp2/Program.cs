using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0, oper1 = 0, oper2 = 0,resultado = 0;
           
            Console.WriteLine("1.suma");
            Console.WriteLine("2.resta");
            Console.WriteLine("3.multiplcacion");
            Console.WriteLine("Escribe la opcion");
            op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserta el primer operando");
            oper1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserta el segundo operando");
            oper2 = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1: suma(oper1, oper2);
                    break;
                case 2: resta(oper1, oper2); 
                    resultado = resta(oper1, oper2);
                    Console.WriteLine($"el resultado es {resultado}");
                    break;
                default:
                    Console.WriteLine("operacion no valida");
                    break;
            } //fin del main
        }
        //empiezan los metodos
        //que permiten hacer operaciones aritmeticas
        static void suma(int op1, int op2)
        {
            Console.WriteLine("la suma es: " + (op1 + op2));

        }
        static int resta(int op1, int op2)
        { 
            return op1 - op2;
        }

    }
}
