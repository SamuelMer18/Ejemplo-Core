using Microsoft.EntityFrameworkCore;
using Ejemplo1Core.Models;

namespace Ejemplo1Core.Data
{
    public class PracticaContext : DbContext
    {
        public PracticaContext(DbContextOptions<PracticaContext> options): base(options)
        {

        }

        //aqui indicamos que la tabla se llamara libro y que sera de la clase libro
        public DbSet<libro> libro { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
    }
}
