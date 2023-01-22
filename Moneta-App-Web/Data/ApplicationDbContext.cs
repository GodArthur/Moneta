using Microsoft.EntityFrameworkCore;
using Moneta_App_Web.Models;

namespace Moneta_App_Web.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 

        }
        public DbSet<Users> Users { get; set; }


    }
}
