using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaVentas.Data
{
    internal class Conexion
    {
        private static string cadenaConexion = "Server=localhost;Database=SistemaVentasDB;Uid=root;Pwd=;";
        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}
