using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moneta_App_Web.Models
{
    public class Transactions
    {
        [Key]
        public int transaction_id { get; set; }
        
        public double total_spent { get; set; }
        
        public DateTime? transaction_date { get; set; }
        
        public string? company { get; set; }
        
        [ForeignKey(nameof(Categories.category_id))]
        public int category { get; set; }
        
        [ForeignKey(nameof(Users.user_id))]
        public int user_id { get; set;}
    }
}
