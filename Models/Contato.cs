using System.ComponentModel.DataAnnotations;

namespace AgendaAPI.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo não pode ser nulo!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo não pode ser nulo!")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
