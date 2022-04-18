using Microsoft.EntityFrameworkCore;

namespace CarShop.Data
{
    public class CarShopDbContext : DbContext
    {
        public DbSet<User> Users { get; init; }
        public DbSet<Car> Cars { get; init; }
        public DbSet<Issue> Issues { get; init; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-SB9MJ7T\SQLEXPRESS;Database=CarShop;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
