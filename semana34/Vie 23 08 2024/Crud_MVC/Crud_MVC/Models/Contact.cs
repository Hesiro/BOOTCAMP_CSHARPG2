using System.ComponentModel.DataAnnotations;

namespace Crud_MVC.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es necesario ingresar un nombre")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage ="Es necesario ingresar un telefono")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "Es necesario ingresar un celular")]
        public string? Celular { get; set; }

        [Required(ErrorMessage = "Es necesario ingresar un email")]
        public string? Email { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
