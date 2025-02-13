﻿using asp.netIntro.Entities;
using Microsoft.EntityFrameworkCore;

namespace asp.netIntro.Data
{
    public class ECommerceDbContext:DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options):base(options) { }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order>Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c=>c.Orders)
                .HasForeignKey(o => o.CustomerId);

            modelBuilder.Entity<Order>()
                .HasOne(o=>o.Product)
                .WithMany(d=>d.Orders)
                .HasForeignKey(o => o.ProductId);
        }
    }
}
