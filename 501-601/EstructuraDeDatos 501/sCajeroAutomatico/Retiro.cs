using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCajeroAutomatico
{
    internal class Retiro : Transaccion
    {
        private readonly Teclado teclado;
        private readonly DispensadorEfectivo dispensador;
        private readonly int[] opciones = new int[] { 200, 500, 1000, 2000, 0 }; // 0 = Cancelar

        public Retiro(int numeroCuenta, BaseDatosBanco baseDatos, Pantalla pantalla, Teclado teclado, DispensadorEfectivo dispensador)
            : base(numeroCuenta, baseDatos, pantalla)
        {
            this.teclado = teclado;
            this.dispensador = dispensador;
        }

        public override void Ejecutar()
        {
            int monto = MostrarMenuMontos();

            if (monto == 0)
            {
                Pantalla.MostrarLinea("Transacción cancelada por el usuario.");
                return;
            }

            decimal saldo = BaseDatos.ObtenerSaldo(NumeroCuenta);

            if (monto > saldo)
            {
                Pantalla.MostrarLinea("Fondos insuficientes en la cuenta.");
                return;
            }

            if (!dispensador.TieneFondos(monto))
            {
                Pantalla.MostrarLinea("El cajero no tiene suficiente efectivo. Intente con un monto menor.");
                return;
            }

            // Efectuar retiro
            BaseDatos.Debitar(NumeroCuenta, monto);
            dispensador.Dispensar(monto);

            Pantalla.MostrarLinea($"Retiro exitoso. Se dispensaron ${monto:N0}.");
            Pantalla.MostrarLinea($"Nuevo saldo: ${BaseDatos.ObtenerSaldo(NumeroCuenta):N2}");
        }

        private int MostrarMenuMontos()
        {
            Pantalla.MostrarLinea("Seleccione el monto de retiro:");
            Pantalla.MostrarLinea("1 - $200");
            Pantalla.MostrarLinea("2 - $500");
            Pantalla.MostrarLinea("3 - $1,000");
            Pantalla.MostrarLinea("4 - $2,000");
            Pantalla.MostrarLinea("5 - Cancelar");
            Pantalla.Mostrar("Opción: ");

            int opcion = teclado.LeerEntero();

            if (opcion < 1 || opcion > 5)
            {
                Pantalla.MostrarLinea("Opción inválida. Se cancela la transacción.");
                return 0;
            }

            return opciones[opcion - 1];
        }
    }
}
