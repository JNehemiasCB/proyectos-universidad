namespace mundialFutbol.Excepciones
{

    using System;

    // Debe heredar de la clase base Exception
    public class EquipoExistenteException : Exception
    {
        /**
         * Constructor que acepta el nombre del equipo duplicado.
         * * Llama al constructor base de 'Exception' con un mensaje descriptivo.
         * Este mensaje será capturado y mostrado al usuario en la interfaz.
         */
        public EquipoExistenteException(string nombreEquipo)
            : base($"El equipo con nombre '{nombreEquipo}' ya existe en el Mundial. El nombre debe ser único.")
        {
        }

        // Opcional: Puedes añadir un constructor que acepte un mensaje personalizado
        public EquipoExistenteException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}