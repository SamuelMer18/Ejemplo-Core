using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejemplo1Core.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int LibroId { get; set; }
        public int EstudianteId { get; set; }

        [ForeignKey("LibroId")]
        public virtual libro Libro { get; set; }

        [ForeignKey("EstudianteId")]
        public virtual Estudiante Estudiante { get; set; }
    }
}