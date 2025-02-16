﻿using CoffeeNew.Models;
using CoffeeNew.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CoffeeNew.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<News> News => Set<News>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<User>()
                .Property(e => e.Created)
                .HasDefaultValueSql("now()");

            modelBuilder
                .Entity<News>()
                .Property(e => e.Date)
                .HasDefaultValueSql("now()");

            modelBuilder
                .Entity<News>()
                .Property(e => e.CreateDate)
                .HasDefaultValueSql("now()");

            modelBuilder
                .Entity<News>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true);
        }

    }
}
