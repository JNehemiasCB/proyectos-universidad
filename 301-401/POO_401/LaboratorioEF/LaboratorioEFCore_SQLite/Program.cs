using LaboratorioEFCore_SQLite;
using Microsoft.EntityFrameworkCore;

class program
{
    static void Main(string[] args)
    {
        using (var dbContext = new EscuelaContext())
        {
            dbContext.Database.Migrate();
        }

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("         ADMINISTRACION DE ESTUDIANTES           ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("1. Añadir nuevo estudiante");
            Console.WriteLine("2. Ver todos los estudiantes");
            Console.WriteLine("3. Actualizar estudiante");
            Console.WriteLine("4. Eliminiar estudiante");
            Console.WriteLine("5. Salir");
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Seleccione una opcion: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                    case "1":
                        AniadeEstudiante();
                        break;
                    case "2":
                        VerEstudiante();
                        break;
                    case "3":
                        ActualizaEstudiantes();
                        break;
                    case "4":
                        BorrarEstudiante();
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Saliendo de la aplicacion. ¡Hasta pronto!");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Presione cualquier tecla para intentar de nuevo.");
                        Console.ReadKey();
                        break;
            }
            if (running && choice != "5")
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void AniadeEstudiante()
        {
            Console.Clear();
            Console.WriteLine("--- Añadir Nuevo Estudiante ---");
            Console.Write("Nombre del estudiante: ");
            string nombre = Console.ReadLine();

            DateTime fechaNacimiento;
            while (true)
            {
                Console.Write("Fecha de Nacimiento (YYYY-MM-DD): ");
                string fechaStr = Console.ReadLine();
                if (DateTime.TryParse(fechaStr, out fechaNacimiento))
                {
                    break;
                }
                Console.WriteLine("Formato de fecha invalido. Intente de nuevo.");
            }

            using (var db = new EscuelaContext())
            {
                var newStudent = new Estudiante { Nombre = nombre, FechaNacimiento = fechaNacimiento };
                db.Estudiantes.Add(newStudent);
                db.SaveChanges();
                Console.WriteLine($"Estudiante '{nombre}' añadido con exito. ID: {newStudent.Id}");
            }
        }

        static void VerEstudiante()
        {
            Console.Clear();
            Console.WriteLine("--- Lista de Estudiantes ---");
            using (var db = new EscuelaContext())
            {
                var estudiantes = db.Estudiantes.OrderBy(e => e.Nombre).ToList();
                if (estudiantes.Any())
                {
                    Console.WriteLine("{0,-5} {1,-25} {2,-15}", "ID", "Nombre", "F. Nacimiento");
                    Console.WriteLine("------ ------- --------  ----  --------  --------------");
                    foreach (var e in estudiantes)
                    {
                        Console.WriteLine("{0,-5} {1,-25} {2,-15}", e.Id, e.Nombre, e.FechaNacimiento.ToShortDateString());
                    }
                }
                else
                {
                    Console.WriteLine("No hay estudiantes registrados.");
                }
            }
        }

        static void ActualizaEstudiantes()
        {
            Console.Clear();
            Console.WriteLine("--- Actualizar Estudiante ---");
            Console.Write("Ingrese el ID del estudiante a actualizar: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("ID invalido");
                return;
            }

            using (var db = new EscuelaContext())
            {
                var studentToUpdate = db.Estudiantes.Find(id);

                if (studentToUpdate == null)
                {
                    Console.WriteLine($"Estudiantes con ID {id} no encontrado.");
                    return;
                }

                Console.WriteLine($"Estudiantes actual: ID: {studentToUpdate.Id}, Nombre: {studentToUpdate.Nombre}, " + $"Fecha Nacimiento: {studentToUpdate.FechaNacimiento.ToShortDateString()}");

                Console.Write("Nuevo nombre (dejar en blanco para no cambiar): ");
                string newNombre = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newNombre))
                {
                    studentToUpdate.Nombre = newNombre;
                }

                DateTime newFechaNacimiento;
                Console.Write("Nueva Fecha de Nacimiento (YYYY-MM-DD, dejar en blanco para no cambiar): ");
                string newFechaStr = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newFechaStr))
                {
                    if (DateTime.TryParse(newFechaStr, out newFechaNacimiento))
                    {
                        studentToUpdate.FechaNacimiento = newFechaNacimiento;
                    }
                    else
                    {
                        Console.WriteLine("Formato de fecha inválido. La fecha de nacimiento no será actualizada.");
                    }
                }

                db.SaveChanges();
                Console.WriteLine($"Estudiante con ID {id} actualizado con éxito.");
            }
        }

        static void BorrarEstudiante()
        {
            Console.Clear();
            Console.WriteLine("--- Eliminar Estudiante ---");
            Console.Write("Ingrese el ID del estudiante a eliminar: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("ID inválido.");
                return;
            }

            using (var db = new EscuelaContext())
            {
                var studentToDelete = db.Estudiantes.Find(id);

                if (studentToDelete == null)
                {
                    Console.WriteLine($"Estudiante con ID {id} no encontrado.");
                    return;
                }

                Console.Write($"¿Está seguro de que desea eliminar a '{studentToDelete.Nombre}' (ID: {id})? (S/N): ");
                string confirmation = Console.ReadLine().ToUpper();

                if (confirmation == "S")
                {
                    db.Estudiantes.Remove(studentToDelete);
                    db.SaveChanges();
                    Console.WriteLine($"Estudiante '{studentToDelete.Nombre}' (ID: {id}) eliminado con éxito.");
                }
                else
                {
                    Console.WriteLine("Operación de eliminación cancelada.");
                }
            }
        }
    }
}
