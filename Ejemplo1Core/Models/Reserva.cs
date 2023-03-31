using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejemplo1Core.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey("LibroId")]

        public int LibroId { get; set; }
        [ForeignKey("EstudianteId")]

        public int EstudianteId { get; set; }

       /* public virtual libro Libro { get; set; }
        public virtual Estudiante Estudiante { get; set; }*/
    }
}