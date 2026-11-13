using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFListBox
{
    internal class ArchivoTexto
    {
        private string rutaArchivo = @"C:\PruebaText";

        public ArchivoTexto(string rutaArchivo)
        {
        this.rutaArchivo = rutaArchivo;
        }

        public void CrearArchivo()
        {
        if(!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close();//Crea el archivo y lo cierra inmediatamente
                //Console.WriteLine("El archivo se ha creado con exito.");
                MessageBox.Show("Archivo creado con exito");
            }
        else
            {
                //Console.WriteLine("El archivo ya existe");
            }
        }

        public void EscribirTexto(string texto)
        {
         if(!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, texto);
            }
         else
            {
                File.AppendAllText(rutaArchivo,texto + Environment.NewLine);
            }
        }

        public string LeerTexto()
        {
            if(File.Exists(rutaArchivo))
            {
                return File.ReadAllText(rutaArchivo);
            }
            else
            {
                return "El archivo no existe";
            }
        }
    }
}
