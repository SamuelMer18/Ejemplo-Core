using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejemplo1Core.Models
{
    public class Reserva
    {
        [Key]
        private int id;
        private DateTime fecha;
        [ForeignKey("idest")]
        private int idest;
        [ForeignKey("idlibro")]
        private int idlibro;

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Idest { get => idest; set => idest = value; }
        public int Idlibro { get => idlibro; set => idlibro = value; }

        public virtual libro Libro { get; set; }
        public virtual Estudiante Estudiante { get; set; }
    }
}
