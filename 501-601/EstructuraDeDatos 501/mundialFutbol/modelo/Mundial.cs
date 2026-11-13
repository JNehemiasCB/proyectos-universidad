namespace mundialFutbol.modelo
{

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq; // Necesario para Linq
    using System.Text.Json;

    // Asegúrate de tener referencias a las clases Equipo, Jugador y a las excepciones.

    public class Mundial
    {
        // Propiedades
        public Dictionary<string, Equipo> Equipos { get; set; } = new Dictionary<string, Equipo>();
        // Ruta por defecto para persistencia, crea la carpeta 'data' si no existe.
        public string RutaArchivoPersistencia { get; set; } = Path.Combine("data", "mundial_data.json");
        // Ruta base para los reportes de nómina
        private const string RutaBaseReportes = "data\\reportes";


        // Constructor privado para forzar la carga a través del método estático CargarEstado (Mejora de POO)
        private Mundial()
        {
            // Asegurar que el directorio de reportes exista al inicializar
            if (!Directory.Exists(RutaBaseReportes))
            {
                Directory.CreateDirectory(RutaBaseReportes);
            }
        }

        // =======================================================================
        // METODOS DE PERSISTENCIA (Serialización JSON)
        // =======================================================================

        // Método estático para Cargar el Estado
        public static Mundial CargarEstado()
        {
            // El documento requiere manejo de errores I/O [cite: 61, 70]
            try
            {
                // Crear el directorio 'data' si no existe
                var dataDirectory = Path.GetDirectoryName(new Mundial().RutaArchivoPersistencia);
                if (!Directory.Exists(dataDirectory))
                {
                    Directory.CreateDirectory(dataDirectory);
                }

                if (File.Exists(new Mundial().RutaArchivoPersistencia))
                {
                    string jsonString = File.ReadAllText(new Mundial().RutaArchivoPersistencia);
                    // Usar opciones para permitir la lectura/escritura de propiedades privadas (setter)
                    var options = new JsonSerializerOptions { IncludeFields = true };
                    var mundial = JsonSerializer.Deserialize<Mundial>(jsonString, options);

                    if (mundial != null)
                    {
                        // Asegurar la inicialización de colecciones
                        if (mundial.Equipos == null) mundial.Equipos = new Dictionary<string, Equipo>();
                        return mundial;
                    }
                }
            }
            catch (IOException ex)
            {
                throw new Exception($"Error de I/O al cargar el estado del Mundial: {ex.Message}");
            }
            catch (JsonException ex) // Error de formato de archivo [cite: 73]
            {
                throw new Exception($"Error de formato de archivo JSON al cargar el estado del Mundial: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocurrió un error inesperado al cargar el estado: {ex.Message}");
            }

            // Si el archivo no existe o hubo un error manejado, retornar una nueva instancia
            return new Mundial();
        }

        // Método para Salvar el Estado
        public void SalvarEstado()
        {
            // Debe manejar errores de I/O y evitar que el programa termine si hay error [cite: 63]
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
                string jsonString = JsonSerializer.Serialize(this, options);
                File.WriteAllText(this.RutaArchivoPersistencia, jsonString);
            }
            catch (IOException ex)
            {
                throw new Exception($"Error de I/O al salvar el estado del Mundial: {ex.Message}");
            }
        }


        // =======================================================================
        // METODOS DE GESTION DE FUNCIONALIDAD
        // =======================================================================

        // Implementa la validación de unicidad del nombre del equipo [cite: 47, 66]
        public void AgregarEquipo(Equipo nuevoEquipo)
        {
            if (Equipos.ContainsKey(nuevoEquipo.Nombre))
            {
                // Lanzar excepción personalizada (EquipoExistenteException)
                throw new EquipoExistenteException(nuevoEquipo.Nombre);
            }
            Equipos.Add(nuevoEquipo.Nombre, nuevoEquipo);
        }

        // Agrega un jugador a un equipo existente [cite: 48]
        public void AgregarJugadorAEquipo(string nombreEquipo, Jugador nuevoJugador)
        {
            if (!Equipos.ContainsKey(nombreEquipo))
            {
                // Lanza una excepción si el equipo no se encuentra
                throw new KeyNotFoundException($"El equipo '{nombreEquipo}' no fue encontrado.");
            }

            // Delega la lógica de agregar jugador al objeto Equipo
            Equipos[nombreEquipo].AgregarJugador(nuevoJugador);
            // Nota: El método AgregarJugador del Equipo debe lanzar JugadorExistenteException.
        }

        // Genera un reporte de nómina para un equipo específico [cite: 48]
        public string GenerarReporteNomina(string nombreEquipo)
        {
            if (!Equipos.ContainsKey(nombreEquipo))
            {
                throw new KeyNotFoundException($"El equipo '{nombreEquipo}' no fue encontrado.");
            }

            // 1. Llama al método del equipo para calcular la nómina [cite: 48]
            var equipo = Equipos[nombreEquipo];
            decimal nominaTotal = equipo.CalcularNomina();

            // 2. Generar un nombre único [cite: 48]
            string nombreArchivo = $"Nomina_{equipo.Nombre}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string rutaCompleta = Path.Combine(RutaBaseReportes, nombreArchivo);

            // 3. Escribir el archivo en "data\reportes" [cite: 48, 70]
            try
            {
                var contenido = new StringBuilder();
                contenido.AppendLine($"*** REPORTE DE NÓMINA - {equipo.Nombre.ToUpper()} ***");
                contenido.AppendLine($"Fecha de Generación: {DateTime.Now}");
                contenido.AppendLine($"Director Técnico: {equipo.DirectorTecnico}");
                contenido.AppendLine("-----------------------------------------");
                contenido.AppendLine($"NÓMINA TOTAL DEL EQUIPO: ${nominaTotal:N2} USD");
                contenido.AppendLine("-----------------------------------------");

                // Opcional: Lista detallada de salarios de jugadores
                foreach (var jugador in equipo.Jugadores.Values.OrderByDescending(j => j.Salario))
                {
                    contenido.AppendLine($"- {jugador.Nombre} ({jugador.Posicion}): ${jugador.Salario:N2}");
                }

                File.WriteAllText(rutaCompleta, contenido.ToString());
                return rutaCompleta; // Retorna la ruta del reporte generado
            }
            catch (IOException ex)
            {
                throw new Exception($"Error de I/O al generar el reporte de nómina: {ex.Message}");
            }
        }

        // Gestiona la lectura del archivo y la actualización de los datos [cite: 49]
        public void ModificarJugadoresDesdeArchivo(string rutaArchivo)
        {
            // El documento requiere manejo de errores I/O, formato y lógica [cite: 64, 70, 73]
            if (!File.Exists(rutaArchivo))
            {
                throw new FileNotFoundException($"El archivo no existe en la ruta: {rutaArchivo}");
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);
            int lineaActual = 0;
            var resultados = new List<string>();

            foreach (string linea in lineas)
            {
                lineaActual++;
                try
                {
                    // Formato esperado: NombreEquipo;NombreJugador;Propiedad;NuevoValor
                    string[] partes = linea.Split(';');
                    if (partes.Length != 4)
                    {
                        throw new FormatException("Formato de línea incorrecto. Se esperan 4 campos separados por ';'.");
                    }

                    string nombreEquipo = partes[0].Trim();
                    string nombreJugador = partes[1].Trim();
                    string propiedad = partes[2].Trim().ToLower();
                    string valor = partes[3].Trim();

                    if (!Equipos.ContainsKey(nombreEquipo))
                    {
                        throw new KeyNotFoundException($"Equipo '{nombreEquipo}' no encontrado.");
                    }

                    if (!Equipos[nombreEquipo].Jugadores.ContainsKey(nombreJugador))
                    {
                        throw new KeyNotFoundException($"Jugador '{nombreJugador}' no encontrado en el equipo.");
                    }

                    var jugador = Equipos[nombreEquipo].Jugadores[nombreJugador];

                    // Actualización de propiedades (usa switch o if/else)
                    switch (propiedad)
                    {
                        case "edad":
                            jugador.Edad = int.Parse(valor);
                            break;
                        case "altura":
                            jugador.Altura = double.Parse(valor, System.Globalization.CultureInfo.InvariantCulture);
                            break;
                        case "peso":
                            jugador.Peso = double.Parse(valor, System.Globalization.CultureInfo.InvariantCulture);
                            break;
                        case "salario":
                            jugador.Salario = decimal.Parse(valor, System.Globalization.NumberStyles.Currency | System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture);
                            break;
                        case "posicion":
                            // Convierte string a enum, lanzará excepción si el valor no es válido
                            jugador.Posicion = (PosicionJugador)Enum.Parse(typeof(PosicionJugador), valor.ToUpper());
                            break;
                        case "rutafoto":
                            jugador.RutaFoto = valor;
                            break;
                        default:
                            throw new ArgumentException($"Propiedad '{propiedad}' no válida para actualización.");
                    }

                    resultados.Add($"Línea {lineaActual}: Jugador '{nombreJugador}' actualizado con éxito.");

                }
                catch (FormatException ex)
                {
                    resultados.Add($"Línea {lineaActual}: ERROR de FORMATO. {ex.Message}");
                }
                catch (ArgumentException ex) // Para errores de 'default' y errores de Parse
                {
                    resultados.Add($"Línea {lineaActual}: ERROR de VALOR. {ex.Message}");
                }
                catch (Exception ex)
                {
                    resultados.Add($"Línea {lineaActual}: ERROR LÓGICO/I/O. {ex.Message}");
                }
            }

            // Retorna un resumen de las operaciones para notificar al usuario (UI)
            throw new Exception("Proceso de actualización terminado.\n\n" + string.Join("\n", resultados));
        }


        // El documento pide un método para presentar información, pero la UI lo hace. 
        // Lo implementaremos para que el modelo lo pueda usar.
        public Jugador PresentarInformacionJugador(string nombreEquipo, string nombreJugador)
        {
            // El documento requiere este método [cite: 47]
            if (!Equipos.ContainsKey(nombreEquipo))
            {
                throw new KeyNotFoundException($"El equipo '{nombreEquipo}' no fue encontrado.");
            }

            if (!Equipos[nombreEquipo].Jugadores.ContainsKey(nombreJugador))
            {
                throw new KeyNotFoundException($"El jugador '{nombreJugador}' no fue encontrado en el equipo.");
            }

            return Equipos[nombreEquipo].Jugadores[nombreJugador];
        }
    }
}