using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCajeroAutomatico
{
    internal class Cuenta
    {
        public int NumeroCuenta { get; }
        public int Nip { get; }
        public decimal Saldo { get; private set; }
        public Cuenta(int numeroCuenta, int nip, decimal saldoInicial)
        {
            NumeroCuenta = numeroCuenta;
            Nip = nip;
            Saldo = saldoInicial;
        }
        public void Acreditar(decimal monto) => Saldo += monto; //depósito
        public void Debitar(decimal monto)
        {
            if (monto > Saldo) throw new System.InvalidOperationException
            ("Fondos insuficientes.");
            Saldo -= monto; // retiro
        }
    }
}
