namespace Git.Data
{
    using Git.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Commit> Commits { get; init; }

        public DbSet<Repository> Repositories { get; init; }

        public DbSet<User> Users { get; init; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-SB9MJ7T\SQLEXPRESS;Database=Git;Trusted_Connection=True");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}