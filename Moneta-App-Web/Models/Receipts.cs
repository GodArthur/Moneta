using System.ComponentModel.DataAnnotations;

namespace Moneta_App_Web.Models
{
    public class Receipts
    {
        [Key]
        public int receipt_num { get; set; }

        [Required]
        public string screenshot { get; set; }
    }
}
