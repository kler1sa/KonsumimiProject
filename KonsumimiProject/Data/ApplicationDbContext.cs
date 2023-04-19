using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KonsumimiProject.Models;

namespace KonsumimiProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<KonsumimiProject.Models.Product> Products { get; set; }
        public DbSet<KonsumimiProject.Models.Orders> Orders { get; set; }
        public DbSet<KonsumimiProject.Models.OrderDetails> OrderDetails { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}