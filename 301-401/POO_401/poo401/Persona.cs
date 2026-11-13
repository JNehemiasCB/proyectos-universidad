using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo401
{
    class Persona
    {
        public string nombre;

        public void SetNombre(string Pnombre)
        {
            nombre = Pnombre;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {nombre}");
        }
    }
}
