using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efec_tarjeta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tarjeta = 0;
            int efectivo = 0;
            int metodopago = 0; 
            int op = 0;
            double precioproduct = 0.0;
            bool menu = true;
            while (menu)
            {
                while (op == 3)
                {
                    Console.WriteLine("ingresa el precio del producto");
                    precioproduct = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingresa el metodo de pago");
                    if (metodopago == efectivo)
                    {
                        Console.WriteLine($"le cobro {precioproduct}");
                    }
                    else if (metodopago == tarjeta)
                    {
                        Console.WriteLine("ingresa el numero de tu tarjeta");
                    }
                    Console.WriteLine("quieres seguir??");
                    Console.WriteLine("1.Si, 2.No");
                    op = Convert.ToInt32(Console.ReadLine());
                    if (op == 1)
                    {
                        menu = true;
                    }
                    else
                        menu = false;
                }
            }
        }

    }
}
