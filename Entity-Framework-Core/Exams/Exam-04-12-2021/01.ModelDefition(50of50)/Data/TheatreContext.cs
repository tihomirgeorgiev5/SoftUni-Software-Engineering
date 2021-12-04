﻿namespace Theatre.Data
{
    using Microsoft.EntityFrameworkCore;
    using Theatre.Data.Models;

    public class TheatreContext : DbContext
    {
        public TheatreContext() { }

        public TheatreContext(DbContextOptions options)
            : base(options) { }

        public virtual DbSet<Theatre> Theatres { get; set; }

        public virtual DbSet<Play> Plays { get; set; }

        public virtual DbSet<Cast> Casts { get; set; }

        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>(t =>
            {
                t.HasKey(tk => new
                {
                    tk.PlayId,
                    tk.TheatreId
                });
            });

            modelBuilder.Entity<Cast>(e =>
            {
                e.HasOne(g => g.Play)
                .WithMany(m => m.Casts)
                .HasForeignKey(g => g.PlayId)
                .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }


    
}
