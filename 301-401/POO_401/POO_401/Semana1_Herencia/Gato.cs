using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Herencia
{
    internal class Gato:Animal
    {
        public Gato(string nombre):base(nombre) { }

        public override void HacerSonido()
        {
            Console.WriteLine("El Gato maulla");
        }
    }
}
