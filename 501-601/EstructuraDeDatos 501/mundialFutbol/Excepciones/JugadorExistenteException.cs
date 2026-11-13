namespace mundialFutbol.Excepciones
{

    using System;
    public class JugadorExistenteException : Exception
    {
        // Hereda del constructor base de Exception
        public JugadorExistenteException(string nombre)
            : base($"El jugador con nombre '{nombre}' ya existe en el equipo.")
        {
        }
        // Puedes agregar más constructores si lo necesitas.
    }
}