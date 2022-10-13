using System;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Domain.Entities.Common;
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
        public DbSet<ShippingAddress> ShippingAddresses { get; set; }
        public DbSet<BillingAddress> BillingAddresses { get; set; }
        public DbSet<Basket> Basket { get; set; }

        // Interceptor, insert ve update dataları yakalayıp üzerinde değişiklik yapmak
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // ChangeTracker : Entityler üzerinde yapılan değişikliklerin ya da yeni eklenen verinin yakalanmasını sağlayan property'dir.
            // Update operasyonlarında track edilen verileri yakalayıp elde etmemizi sağlar.

            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach(var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    EntityState.Unchanged => data.Entity.UpdatedDate = DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}

