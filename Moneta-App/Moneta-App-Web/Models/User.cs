using System.ComponentModel.DataAnnotations;

namespace Moneta_App_Web.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string?  FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public DateTime birthDate { get; set; }

    }
}
