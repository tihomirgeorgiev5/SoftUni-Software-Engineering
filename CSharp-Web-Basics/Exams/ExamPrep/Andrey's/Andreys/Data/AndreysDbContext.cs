﻿namespace Andreys.Data
{
    using Andreys.Models;
    using Microsoft.EntityFrameworkCore;

    public class AndreysDbContext : DbContext
    {
        public AndreysDbContext()
        {
           
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SB9MJ7T\SQLEXPRESS;Database=Andrey's;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }



    }
}
