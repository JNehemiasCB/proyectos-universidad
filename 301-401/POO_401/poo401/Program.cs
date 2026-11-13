using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo401
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona2 = new Persona();
            Persona persona1 = new Persona();

            persona1.SetNombre("nehemias");
            persona2.SetNombre("jesus nehemias");

            persona1.Saludar();
            persona2.Saludar();
        }
    }
}
