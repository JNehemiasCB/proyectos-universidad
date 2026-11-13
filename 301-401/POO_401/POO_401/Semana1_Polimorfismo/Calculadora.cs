using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Polimorfismo
{
    internal class Calculadora
    {
        //Sobrecarga de metodos
        /*
        Polimorfismo de Compilación (Sobrecarga):
        Ocurre cuando se declaran múltiples métodos con el mismo nombre
        pero diferentes parámetros en una misma clase.
         */
        public int Sumar(int a, int b)
        {
            return a + b;
        }
        public double Sumar(double a, double b)
        {
            return a + b;
        }
        public int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
