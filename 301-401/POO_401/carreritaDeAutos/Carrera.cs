using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carreritaDeAutos
{
    internal class Carrera
    {
        Automovil coche1 = new Automovil("rayoMquin", 10, 10);
        Automovil coche2 = new Automovil("bigotes", 9, 9);

        public void SimularCarrera()
        {
            Random random = new Random();
            coche1.distanciaRecorrida = random.Next();
            coche2.distanciaRecorrida = random.Next();
            coche1.Acelerar();
            coche2.Acelerar();
            Console.WriteLine("Fin de la carrera");
            if (coche1.distanciaRecorrida > coche2.distanciaRecorrida)
            {
                Console.WriteLine("Gano el rayo Mquin");
            }
            else
            {
                Console.WriteLine("Gano bigotes");
            }
        }
    }

}
