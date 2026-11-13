using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Moto:Vehiculo
    {
        public Moto(string marca, string modelo) : base(marca, modelo) { }
        public override void MostrarDetalles()
        {
            Console.WriteLine($"Marca:{Marca}, Modelo:{Modelo}");
        }
    }
}
