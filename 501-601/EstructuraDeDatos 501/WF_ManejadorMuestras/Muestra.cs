using System;
using System.Linq;

namespace WF_ManejadorMuestras
{
    public class Muestra
    {
        protected int[] valores;
        protected int tamaño;
        protected int limite;
        private static Random rnd = new Random();
        public int Limite => limite;

        public Muestra(int tamaño, int limite)
        {
            this.tamaño = tamaño;
            this.limite = limite;
            valores = new int[tamaño];
        }

        public void GeneraValores()
        {
            for (int i = 0; i < tamaño; i++)
                valores[i] = rnd.Next(1, limite + 1);
        }

        public int[] ObtenerValores()
        {
            return valores;
        }

        public int DarMínimo() => valores.Min();
        public int DarMáximo() => valores.Max();
        public double DarPromedio() => valores.Average();

        public MuestraOrdenada OrdenaBurbuja()
        {
            int[] copia = (int[])valores.Clone();
            for (int i = 0; i < copia.Length - 1; i++)
                for (int j = 0; j < copia.Length - i - 1; j++)
                    if (copia[j] > copia[j + 1])
                        (copia[j], copia[j + 1]) = (copia[j + 1], copia[j]);

            return new MuestraOrdenada(copia);
        }

        public MuestraOrdenada OrdenaSelección()
        {
            int[] copia = (int[])valores.Clone();
            for (int i = 0; i < copia.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < copia.Length; j++)
                    if (copia[j] < copia[min])
                        min = j;

                (copia[i], copia[min]) = (copia[min], copia[i]);
            }
            return new MuestraOrdenada(copia);
        }

        public MuestraOrdenada OrdenaInserción()
        {
            int[] copia = (int[])valores.Clone();
            for (int i = 1; i < copia.Length; i++)
            {
                int aux = copia[i];
                int j = i - 1;
                while (j >= 0 && copia[j] > aux)
                {
                    copia[j + 1] = copia[j];
                    j--;
                }
                copia[j + 1] = aux;
            }
            return new MuestraOrdenada(copia);
        }
    }
}
