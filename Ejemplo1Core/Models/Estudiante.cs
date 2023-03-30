using System.ComponentModel.DataAnnotations;

namespace Ejemplo1Core.Models
{
    public class Estudiante
    {
        [Key]
        private int id;
        private string nombre;
        private string apellido;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
