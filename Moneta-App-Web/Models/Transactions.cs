using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moneta_App_Web.Models
{
    public class Transactions
    {
        [Key]
        public int transaction_id { get; set; }
        [Required]
        public double total_spent { get; set; }
        [Required]
        public DateTime? transaction_date { get; set; }
        [Required]
        public string? company { get; set; }
        [Required]
        [ForeignKey(nameof(Categories.category_id))]
        public int category { get; set; }
        [Required]
        [ForeignKey(nameof(Receipts.receipt_num))]
        public int receipt_num { get; set; }
        [Required]
        [ForeignKey(nameof(Users.user_id))]
        public int user_id { get; set;}
    }
}
