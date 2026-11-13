using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArchivoTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("texto.txt");
                line = sr.ReadLine();
                while(line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch(Exception ex)  
            {
            Console.WriteLine("Exception: " +ex.Message);
            }
            finally
            {
                Console.WriteLine("ejecutando bloque finally");
            }
            

        }
    }
}
