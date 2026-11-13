namespace mundialFutbol.modelo
{
    using mundialFutbol.Excepciones;
    using mundialFutbol.modelo;
    using System;
    using System.Collections.Generic;
    using System.Linq; // Necesario para Linq, útil para nómina y búsquedas

    public class Equipo
    {
        // Propiedades
        public string Nombre { get; private set; } // Identificador único, inmutable [cite: 29]
        public string PaisOrigen { get; set; }
        public string DirectorTecnico { get; set; }
        public string RutaBandera { get; set; }
        // Colección para almacenar jugadores. Usar Dictionary<string, Jugador>// facilita la búsqueda rápida y asegura la unicidad del nombre del jugador. [cite: 35, 36, 37]
        public Dictionary<string, Jugador> Jugadores { get; set; } = new Dictionary<string, Jugador>();

        // Constructor
        public Equipo(string nombre)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del equipo no puede estar vacío.");
            }
            this.Nombre = nombre;
        }
        // Método: AgregarJugador [cite: 40]
        public void AgregarJugador(Jugador jugador)
        {
            // 1. Implementa la validación de unicidad del nombre del jugador [cite: 40]
            if (Jugadores.ContainsKey(jugador.Nombre))
            {
                // Lanzar una excepción personalizada (que crearás en el paso siguiente)
                throw new JugadorExistenteException(jugador.Nombre);
            }

            Jugadores.Add(jugador.Nombre, jugador);
        }

        // Método: Calcular Nomina() [cite: 41]
        public decimal CalcularNomina()
        {
            // Itera sobre la colección de jugadores y suma sus salarios. [cite: 41]
            // Se usa .Values para iterar sobre los objetos Jugador
            // Se usa LINQ para una implementación limpia.
            return Jugadores.Values.Sum(j => j.Salario);
        }
    }
}