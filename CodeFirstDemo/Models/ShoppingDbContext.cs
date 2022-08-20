using Microsoft.EntityFrameworkCore;

namespace CodeFirstDemo.Models
{
    public class ShoppingDbContext : DbContext
    {
        public ShoppingDbContext(DbContextOptions options) : base(options) { 
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
