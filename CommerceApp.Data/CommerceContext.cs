using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata;
namespace CommerceApp.Data
{
    public class CommerceContext:DbContext
    {
        public string _connection;
        public CommerceContext(DbContextOptions options) { }
        public CommerceContext()
        {
           
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;initial catalog=ProductsDb;integrated security=true;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Ignore<ProductRating>();

        }
    }
}
