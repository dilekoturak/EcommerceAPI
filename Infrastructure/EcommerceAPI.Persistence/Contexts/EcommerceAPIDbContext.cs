using System;
using EcommerceAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace EcommerceAPI.Persistence.Contexts
{
    public class EcommerceAPIDbContext : DbContext
    {
        public EcommerceAPIDbContext(DbContextOptions options) : base(options)
        {
            // bu Constructor IoC container'da doldurulacak
        }

        /* Veritabanı'ndaki entitylerin modellenmesi. Veritabanında Product, Order, Customer entityleri
        olacak diye DbSet ile bildirmek - Code First */

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

