using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_en_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //se inicializa un arreglo bidimensional
            int[,] arr = { { 10, 20, 30, 40, 50 }, 
                { 60, 70, 80, 90, 100 } };
            //variables
            int fila = 0, col = 0;
            
            while (fila < arr.GetLength(0))
            {
                col = 0;
                while (col < arr.GetLength(1))
                {
                    if (arr[fila, col] == 80)
                    {
                        Console.WriteLine("el valor se encuentra en la fila {0} y en la columna {1} y es {2}", fila, col, arr[fila,col]);
                    }
                    col++;
                }
                fila++;
            }
        }
    }
}
