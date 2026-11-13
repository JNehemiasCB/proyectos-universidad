using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCajeroAutomatico
{
    internal class Deposito: Transaccion
    {
        private readonly Teclado teclado;
        private readonly RanuraDeposito ranura;
        public Deposito(int numeroCuenta, BaseDatosBanco baseDatos,
        Pantalla pantalla, Teclado teclado, RanuraDeposito ranura)
        : base(numeroCuenta, baseDatos, pantalla)
        {
            this.teclado = teclado;
            this.ranura = ranura;
        }
        public override void Ejecutar()
        {
            Pantalla.Mostrar("Ingrese el monto a depositar: ");
            decimal monto = teclado.LeerDecimal();
            if (monto <= 0)
            {
                Pantalla.MostrarLinea("Monto inválido. Transacción cancelada.");
            return;
            }
            bool recibido = ranura.RecibirSobre(monto);
            if (!recibido)
            {
                Pantalla.MostrarLinea("No se pudo recibir el depósito. Intente de nuevo.");
            return;
            }
            BaseDatos.Acreditar(NumeroCuenta, monto);
            Pantalla.MostrarLinea($"Depósito registrado por ${ monto: N2}.");
        Pantalla.MostrarLinea($"Nuevo saldo: $ {BaseDatos.ObtenerSaldo(NumeroCuenta):N2}");
        }
    }
}
