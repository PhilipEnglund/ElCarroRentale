using ElCarroRentale.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElCarroRentale.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
    }
}