using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coche = new Coche("Mazda", "3");
            var moto = new Moto("italika", "ft150");
            coche.MostrarDetalles();
            moto.MostrarDetalles();
        }
    }
}
