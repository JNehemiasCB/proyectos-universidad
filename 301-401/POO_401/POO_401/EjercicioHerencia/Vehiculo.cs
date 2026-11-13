using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Vehiculo
    {
        public Vehiculo(string marca, string modelo) 
        {
            Marca = marca;
            Modelo = modelo;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual void MostrarDetalles()
        {
            Console.WriteLine("Muestra detalles del vehiculo");
        }
    }
}
