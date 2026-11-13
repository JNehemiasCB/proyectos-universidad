using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioEFCore_SQLite
{
    internal class EscuelaContext:DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=escuela.db");
        }
    }
}
