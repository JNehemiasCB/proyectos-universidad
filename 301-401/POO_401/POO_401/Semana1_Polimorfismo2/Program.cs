using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Polimorfismo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FiguraGeometrica figura = new Circulo();
            figura.Dibujar();//salida:dibujando circulo
            figura = new Triangulo();
            figura.Dibujar();//salida:dibujando triangulo

        }
    }
}
