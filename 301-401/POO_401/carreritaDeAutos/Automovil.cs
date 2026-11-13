using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carreritaDeAutos
{
        internal class Automovil
        {
            public Automovil(string Nombre, double Combustible, double EstadoNeumaticos)
            {
                this.nombre = Nombre;
                this.combusible = Combustible;
                this.estadoNeumaticos = EstadoNeumaticos;
                this.distanciaRecorrida = 0;
            }

            public string nombre { get; set; }
            public double combusible { get; set; }
            public double estadoNeumaticos { get; set; }
            public int distanciaRecorrida { get; set; }

            public void Acelerar()
            {
                Console.WriteLine($"El auto {nombre} acelera");
            }

            public void Frenar()
            {
                Console.WriteLine("El auto frena");
            }
        }   
}
