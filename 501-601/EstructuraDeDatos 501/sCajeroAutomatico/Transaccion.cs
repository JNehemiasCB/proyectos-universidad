using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCajeroAutomatico
{
    internal abstract class Transaccion
    {
        protected int NumeroCuenta { get; }
        protected BaseDatosBanco BaseDatos { get; }
        protected Pantalla Pantalla { get; }
        protected Transaccion(int numeroCuenta, BaseDatosBanco baseDatos,
        Pantalla pantalla)
        {
            NumeroCuenta = numeroCuenta;
            BaseDatos = baseDatos;
            Pantalla = pantalla;
        }
        public abstract void Ejecutar();
    }
}
