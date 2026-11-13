using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Polimorfismo2
{
    internal class FiguraGeometrica
    {
        public virtual void Dibujar()
        {
            Console.WriteLine("dibujando figura");
        }
    }
    internal class Circulo:FiguraGeometrica
    {
        public override void Dibujar()
        {
            Console.WriteLine("dibujando circulo");
        }
    }
    internal class Triangulo:FiguraGeometrica
    {
        public override void Dibujar()
        {
            Console.WriteLine("dibujando triangulo");
        }
    }
}
