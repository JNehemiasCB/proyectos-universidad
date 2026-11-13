using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sCajeroAutomatico
{
    internal class RanuraDeposito
    {
        public bool RecibirSobre(decimal monto) => monto > 0;
    }
}
