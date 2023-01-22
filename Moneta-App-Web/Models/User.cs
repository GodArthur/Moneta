using System.ComponentModel.DataAnnotations;

namespace Moneta_App_Web.Models
{
    public class Users
    {
        [Key]
        public int user_id { get; set; }
        [Required]
        public string?  first_name { get; set; }
        [Required]
        public string? last_name { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public DateTime date_of_birth { get; set; }

    }
}
