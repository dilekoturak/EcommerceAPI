using System;
using EcommerceAPI.Application.Abstractions;
using EcommerceAPI.Persistence.Concretes;
using EcommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Application.Repositories;

namespace EcommerceAPI.Persistence
{
    public static class ServiceRegistration
    {
        //Extension Method
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            // Hangi sunucuya migration işlemi yapılacaksa...
            services.AddDbContext<EcommerceAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IShippingAddressReadRepository, ShippingAddressReadRepository>();
            services.AddScoped<IShippingAddressWriteRepository, ShippingAddressWriteRepository>();
            services.AddScoped<IBillingAddressReadRepository, BillingAddressReadRepository>();
            services.AddScoped<IBillingAddressWriteRepository, BillingAddressWriteRepository>();
            services.AddScoped<IBasketReadRepository, BasketReadRepository>();
            services.AddScoped<IBasketWriteRepository, BasketWriteRepository>();
        }
    }
}

