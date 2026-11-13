using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCajeroAutomatico
{
    internal class ConsultaSaldo: Transaccion
    {
        public ConsultaSaldo(int numeroCuenta, BaseDatosBanco baseDatos, Pantalla pantalla)
            : base(numeroCuenta, baseDatos, pantalla) { }
        public override void Ejecutar()
        {
            decimal saldo = BaseDatos.ObtenerSaldo(NumeroCuenta);
            Pantalla.MostrarLinea("Su saldo actual es:");
            Pantalla.MostrarMonto(saldo);
        }
    }
}
