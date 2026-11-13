using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.Models;
using SistemaVentas.Data;
using MySql.Data.MySqlClient;

namespace SistemaVentas.Controllers
{
    internal class UsuariosController
    {
        public Usuario Login(string nombre, string password)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                var comando = new MySqlCommand("SELECT * FROM Usuarios WHERE Nombre = @nombre AND Password = @password", conexion);
                

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@password", password);
                var reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    return new Usuario
                    {
                        IdUsuario = reader.GetInt32("IdUsuario"),
                        Nombre = reader.GetString("Nombre"),
                        Rol = reader.GetString("Rol")
                    };
                }
            }
            return null;
        }
    }
}
