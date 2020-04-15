using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlayerTracker.Models;

namespace PlayerTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>()
                .HasData(
                new Team
                {
                    Id = 1,
                    Name = "Packers"
                }, new Team
                {
                    Id = 2,
                    Name = "Bears"
                });

            modelBuilder.Entity<Player>()
                .HasData(
                new Player
                {
                    Id = 1,
                    FirstName = "Aaron",
                    LastName = "Rodgers",
                    TeamId = 1
                });
        }
    }
}
