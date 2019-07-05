using Microsoft.EntityFrameworkCore;
using ProductCore.Entities;
using ProductDataAccess.Configurations;
using System;
using System.Collections.Generic;

namespace ProductDataAccess
{
    public class AwesomeDbContext : DbContext
    {
        public AwesomeDbContext(DbContextOptions<AwesomeDbContext> options) : base(options) { }
        public AwesomeDbContext() { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(e => e.Category).WithMany(c => c.Products).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Category>().HasMany(e => e.Products).WithOne(c => c.Category).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());


            var categories = new[] {
                new { Id = Guid.NewGuid(), Name = "Food" },
                new { Id = Guid.NewGuid(), Name = "Electronics" },
                new { Id = Guid.NewGuid(), Name = "Cars" }
                };
            modelBuilder.Entity<Category>().HasData(categories[0], categories[1], categories[2]);
            modelBuilder.Entity<Product>().HasData(new { Id = Guid.NewGuid(), Name = "Milk GMZ", CategoryId = categories[0].Id, Price = 9.99m, IsActive = true },
                new { Id = Guid.NewGuid(), Name = "TV Samsung 40\"", CategoryId = categories[1].Id, Price = 2999.99m, IsActive = true },
                new { Id = Guid.NewGuid(), Name = "Toyota Tundra V8 4.7L", CategoryId = categories[2].Id, Price = 64999.99m, IsActive = true });

            base.OnModelCreating(modelBuilder);
        }
    }
}
