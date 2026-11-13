using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Herencia
{
    internal class Animal
    {
        public string Nombre { get; set; }
        public Animal(string nombre) 
        {
            Nombre = nombre;
        }

        public virtual void HacerSonido()
        {
            Console.WriteLine("El Animal hace un sonido");
        }
    }
}
