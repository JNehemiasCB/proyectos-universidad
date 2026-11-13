using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

public class ProyectoDAL
{
    private string connectionString;

    public ProyectoDAL(string connString)
    {
        connectionString = connString;
    }

    // Métodos para Proyectos
    public List<Proyecto> ObtenerProyectos()
    {
        var proyectos = new List<Proyecto>();

        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand("SELECT * FROM Proyectos ORDER BY fecha_creacion DESC", conn);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    proyectos.Add(new Proyecto
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Descripcion = reader["descripcion"].ToString(),
                        FechaInicio = Convert.ToDateTime(reader["fecha_inicio"]),
                        FechaFin = Convert.ToDateTime(reader["fecha_fin"]),
                        Estado = reader["estado"].ToString()
                    });
                }
            }
        }

        // Obtener tareas para cada proyecto
        foreach (var proyecto in proyectos)
        {
            proyecto.Tareas = ObtenerTareasPorProyecto(proyecto.Id);
        }

        return proyectos;
    }

    public Proyecto ObtenerProyecto(int id)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand("SELECT * FROM Proyectos WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    var proyecto = new Proyecto
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        Descripcion = reader["descripcion"].ToString(),
                        FechaInicio = Convert.ToDateTime(reader["fecha_inicio"]),
                        FechaFin = Convert.ToDateTime(reader["fecha_fin"]),
                        Estado = reader["estado"].ToString()
                    };

                    proyecto.Tareas = ObtenerTareasPorProyecto(proyecto.Id);
                    return proyecto;
                }
            }
        }
        return null;
    }

    public int InsertarProyecto(Proyecto proyecto)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand(
                "INSERT INTO Proyectos (nombre, descripcion, fecha_inicio, fecha_fin, estado) " +
                "VALUES (@nombre, @descripcion, @fechaInicio, @fechaFin, @estado); SELECT LAST_INSERT_ID();", conn);

            cmd.Parameters.AddWithValue("@nombre", proyecto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", proyecto.Descripcion);
            cmd.Parameters.AddWithValue("@fechaInicio", proyecto.FechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", proyecto.FechaFin);
            cmd.Parameters.AddWithValue("@estado", proyecto.Estado);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }

    public bool ActualizarProyecto(Proyecto proyecto)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand(
                "UPDATE Proyectos SET nombre = @nombre, descripcion = @descripcion, " +
                "fecha_inicio = @fechaInicio, fecha_fin = @fechaFin, estado = @estado " +
                "WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", proyecto.Id);
            cmd.Parameters.AddWithValue("@nombre", proyecto.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", proyecto.Descripcion);
            cmd.Parameters.AddWithValue("@fechaInicio", proyecto.FechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", proyecto.FechaFin);
            cmd.Parameters.AddWithValue("@estado", proyecto.Estado);

            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public bool EliminarProyecto(int id)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand("DELETE FROM Proyectos WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    // Métodos para Tareas
    public List<Tarea> ObtenerTareasPorProyecto(int proyectoId)
    {
        var tareas = new List<Tarea>();

        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand(
                "SELECT t.*, m.nombre as nombre_miembro " +
                "FROM Tareas t LEFT JOIN MiembrosEquipo m ON t.asignado_a_miembro_id = m.id " +
                "WHERE t.proyecto_id = @proyectoId ORDER BY t.fecha_creacion", conn);
            cmd.Parameters.AddWithValue("@proyectoId", proyectoId);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    tareas.Add(new Tarea
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        ProyectoId = Convert.ToInt32(reader["proyecto_id"]),
                        Titulo = reader["titulo"].ToString(),
                        Descripcion = reader["descripcion"].ToString(),
                        FechaInicio = Convert.ToDateTime(reader["fecha_creacion"]),
                        FechaFin = reader["fecha_vencimiento"] != DBNull.Value ?
                                  Convert.ToDateTime(reader["fecha_vencimiento"]) : DateTime.MinValue,
                        Prioridad = reader["prioridad"].ToString(),
                        Estado = reader["estado"].ToString(),
                        AsignadoA = reader["nombre_miembro"] != DBNull.Value ?
                                   reader["nombre_miembro"].ToString() : "Sin asignar"
                    });
                }
            }
        }
        return tareas;
    }

    public int InsertarTarea(Tarea tarea)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand(
                "INSERT INTO Tareas (proyecto_id, titulo, descripcion, fecha_vencimiento, " +
                "prioridad, estado, asignado_a_miembro_id) " +
                "VALUES (@proyectoId, @titulo, @descripcion, @fechaVencimiento, " +
                "@prioridad, @estado, @asignadoA); SELECT LAST_INSERT_ID();", conn);

            cmd.Parameters.AddWithValue("@proyectoId", tarea.ProyectoId);
            cmd.Parameters.AddWithValue("@titulo", tarea.Titulo);
            cmd.Parameters.AddWithValue("@descripcion", tarea.Descripcion);
            cmd.Parameters.AddWithValue("@fechaVencimiento", tarea.FechaFin);
            cmd.Parameters.AddWithValue("@prioridad", tarea.Prioridad);
            cmd.Parameters.AddWithValue("@estado", tarea.Estado);

            // Manejar asignación nula
            if (string.IsNullOrEmpty(tarea.AsignadoA) || tarea.AsignadoA == "Sin asignar")
            {
                cmd.Parameters.AddWithValue("@asignadoA", DBNull.Value);
            }
            else
            {
                // Aquí necesitarías obtener el ID del miembro del equipo por su nombre
                // Esto es un placeholder - deberías implementar esta lógica
                cmd.Parameters.AddWithValue("@asignadoA", ObtenerIdMiembroPorNombre(tarea.AsignadoA));
            }

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }

    public bool ActualizarTarea(Tarea tarea)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand(
                "UPDATE Tareas SET titulo = @titulo, descripcion = @descripcion, " +
                "fecha_vencimiento = @fechaVencimiento, prioridad = @prioridad, " +
                "estado = @estado, asignado_a_miembro_id = @asignadoA " +
                "WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", tarea.Id);
            cmd.Parameters.AddWithValue("@titulo", tarea.Titulo);
            cmd.Parameters.AddWithValue("@descripcion", tarea.Descripcion);
            cmd.Parameters.AddWithValue("@fechaVencimiento", tarea.FechaFin);
            cmd.Parameters.AddWithValue("@prioridad", tarea.Prioridad);
            cmd.Parameters.AddWithValue("@estado", tarea.Estado);

            if (string.IsNullOrEmpty(tarea.AsignadoA) || tarea.AsignadoA == "Sin asignar")
            {
                cmd.Parameters.AddWithValue("@asignadoA", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@asignadoA", ObtenerIdMiembroPorNombre(tarea.AsignadoA));
            }

            return cmd.ExecuteNonQuery() > 0;
        }
    }

    public bool EliminarTarea(int id)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand("DELETE FROM Tareas WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery() > 0;
        }
    }

    // Métodos para Miembros del Equipo
    public List<MiembroEquipo> ObtenerMiembrosEquipo()
    {
        var miembros = new List<MiembroEquipo>();

        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand("SELECT id, nombre, correo_electronico, rol FROM MiembrosEquipo ORDER BY nombre", conn);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    miembros.Add(new MiembroEquipo
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Nombre = reader["nombre"].ToString(),
                        CorreoElectronico = reader["correo_electronico"].ToString(),
                        Rol = reader["rol"].ToString()
                    });
                }
            }
        }
        return miembros;
    }

    private int? ObtenerIdMiembroPorNombre(string nombre)
    {
        using (var conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            var cmd = new MySqlCommand("SELECT id FROM MiembrosEquipo WHERE nombre = @nombre", conn);
            cmd.Parameters.AddWithValue("@nombre", nombre);

            var result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : (int?)null;
        }
    }
}