using System.ComponentModel.DataAnnotations;

namespace Ejemplo1Core.Models
{
    public class libro
    {
        //Aqui indicamos que la propiedad Id es la llave primaria de la tabla
        [Key] 
        private int id;
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre debe ser de almenos de {0} y un maximo de {1}", MinimumLength = 5)]
        private string nombre;
        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        [StringLength(100, ErrorMessage = "La descripcion debe ser de almenos de {0} y un maximo de {1}", MinimumLength = 10)]
        private string descripcion;
        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        private DateTime fecha;
        [Required(ErrorMessage = "El precio es obligatorio")]
        private int precio;
        [Required(ErrorMessage = "El autor es obligatorio")]
        [StringLength(50, ErrorMessage = "El autor debe ser de almenos de {0} y un maximo de {1}", MinimumLength = 5)]
        private string autor;


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Precio { get => precio; set => precio = value; }
    }
}
