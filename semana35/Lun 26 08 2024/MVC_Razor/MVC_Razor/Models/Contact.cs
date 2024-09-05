using System.ComponentModel.DataAnnotations;

namespace MVC_Razor.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingresar nombre")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Ingresar telefono")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Ingresar celular")]
        public string? CellPhone { get; set; }

        [Required(ErrorMessage = "Ingresar email")]
        public string? Email { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
