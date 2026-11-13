using mundialFutbol.modelo;
using System;

public class Jugador
{
    // Propiedades
    public string Nombre { get; private set; } // Inmutable (identificador único dentro del equipo) [cite: 15]
    public int Edad { get; set; }
    public double Altura { get; set; } // Usaremos double para la altura [cite: 19]
    public double Peso { get; set; } // Usaremos double para el peso [cite: 20]
    public PosicionJugador Posicion { get; set; } // Usaremos el Enum [cite: 22, 25]
    public decimal Salario { get; set; } // Fundamental para la nómina, se recomienda decimal para dinero [cite: 23]
    public string RutaFoto { get; set; }

    // Constructor
    public Jugador(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ArgumentException("El nombre del jugador no puede estar vacío.");
        }
        this.Nombre = nombre;
    }

    // Constructor sin parámetros para la serialización JSON (buena práctica)
    public Jugador() { }
}