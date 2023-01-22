using System.ComponentModel.DataAnnotations;

namespace Moneta_App_Web.Models
{
    public class Categories

    {
        [Key]
        public int category_id { get; set; }
        [Required]
        public string? category_name { get; set;}

    }
}
