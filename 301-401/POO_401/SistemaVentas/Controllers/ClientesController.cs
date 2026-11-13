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
    internal class ClientesController
    {
        public List<Cliente> ObtenerClientes()

        {
            var lista = new List<Cliente>();
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                var comando = new MySqlCommand("SELECT * FROM Clientes", conexion);
                var reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Cliente
                    {
                        IdCliente = reader.GetInt32("IdCliente"),
                        Nombre = reader.GetString("Nombre"),
                        Direccion = reader.GetString("Direccion"),
                        Telefono = reader.GetString("Telefono")
                    });
                }
            }
            return lista;
        }
    }
}
