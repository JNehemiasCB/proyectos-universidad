using System.Linq;
using System.Diagnostics;

namespace WF_ManejadorMuestras
{
    public class MuestraOrdenada : Muestra
    {
        public MuestraOrdenada(int[] valores) : base(valores.Length, valores.Max())
        {
            this.valores = valores;
        }

        public bool busquedaSecuencial(int valor)
        {
            foreach (int x in valores)
                if (x == valor)
                    return true;
            return false;
        }

        public bool busquedaBinaria(int valor)
        {
            int inf = 0;
            int sup = valores.Length - 1;
            while (inf <= sup)
            {
                int mid = (inf + sup) / 2;
                if (valores[mid] == valor)
                    return true;
                else if (valores[mid] < valor)
                    inf = mid + 1;
                else
                    sup = mid - 1;
            }
            return false;
        }

        public double tiempoPromedioBusquedaSecuencial()
        {
            Stopwatch reloj = new Stopwatch();
            long totalTicks = 0;

            for (int i = 1; i <= Limite; i++)
            {
                reloj.Restart();
                busquedaSecuencial(i);
                reloj.Stop();
                totalTicks += reloj.ElapsedTicks;
            }

           
            double promedioMs = (totalTicks / (double)Limite) * (1000.0 / Stopwatch.Frequency);
            return promedioMs;
        }


        public double tiempoPromedioBusquedaBinaria()
        {
            Stopwatch reloj = new Stopwatch();
            long totalTicks = 0;

            for (int i = 1; i <= Limite; i++)
            {
                reloj.Restart();
                busquedaBinaria(i);
                reloj.Stop();
                totalTicks += reloj.ElapsedTicks;
            }

            
            double promedioMs = (totalTicks / (double)Limite) * (1000.0 / Stopwatch.Frequency);
            return promedioMs;
        }

      
        
        public int contarElementosEnRango(int inf, int sup)
        {
            return valores.Count(v => v >= inf && v <= sup);
        }

        
        public int cuentaOcurrencias(int valor)
        {
            return valores.Count(v => v == valor);
        }

  
        public int contarValoresDistintos()
        {
            return valores.Distinct().Count();
        }

        public int darValorMasFrecuente()
        {
            return valores
                .GroupBy(v => v)
                .OrderByDescending(g => g.Count())
                .ThenBy(g => g.Key)
                .First()
                .Key;
        }
    }
}
