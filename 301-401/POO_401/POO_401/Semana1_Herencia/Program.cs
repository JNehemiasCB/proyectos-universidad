
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var perro = new Perro("firulais");
            var gato = new Gato("garfield");

            perro.HacerSonido();
            gato.HacerSonido();
        }
    }
}
