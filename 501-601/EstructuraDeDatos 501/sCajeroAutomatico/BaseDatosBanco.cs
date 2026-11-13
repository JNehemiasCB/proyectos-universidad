using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCajeroAutomatico
{
    internal class BaseDatosBanco
    {
        private readonly Dictionary<int, Cuenta> cuentas;

        public BaseDatosBanco()
        {
            // Cuentas de prueba
            cuentas = new Dictionary<int, Cuenta>
            {
                { 12345, new Cuenta(12345, 54321, 5000m) },
                { 67890, new Cuenta(67890, 9876, 12000m) }
            };
        }

        public bool AutenticarUsuario(int numeroCuenta, int nip)
        {
            return cuentas.TryGetValue(numeroCuenta, out var cuenta) &&
                   cuenta.Nip == nip;
        }

        public decimal ObtenerSaldo(int numeroCuenta)
        {
            return cuentas[numeroCuenta].Saldo;
        }

        public void Acreditar(int numeroCuenta, decimal monto)
        {
            cuentas[numeroCuenta].Acreditar(monto);
        }

        public void Debitar(int numeroCuenta, decimal monto)
        {
            cuentas[numeroCuenta].Debitar(monto);
        }
    }
}
