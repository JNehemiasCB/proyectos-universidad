using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolomorfismo
{
    internal class Empleado
    {
        public virtual void CalcularSalario()
        {
            Console.WriteLine("calcula el salario");
        }
    }
    internal class EmpleadoPorHoras:Empleado
    {
        public override void CalcularSalario()
        {

        }
    }
    internal class EmpleadoPorComision:Empleado
    {
        public override void CalcularSalario()
        {

        }
    }
}
    