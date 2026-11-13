using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCajeroAutomatico
{
    internal class DispensadorEfectivo
    {
        public decimal EfectivoDisponible { get; private set; }
        public DispensadorEfectivo(decimal efectivoInicial)
        {
            EfectivoDisponible = efectivoInicial;
        }
        public bool TieneFondos(decimal monto) => EfectivoDisponible >=
        monto;
        public void Dispensar(decimal monto)
        {
            if (!TieneFondos(monto))
                throw new System.InvalidOperationException("El cajero no tiene suficiente efectivo.");
                EfectivoDisponible -= monto;
        }
    }
}
