using System;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Persistence.Contexts;
using EcommerceAPI.Persistence.Repositories;

namespace EcommerceAPI.Persistence.Concretes
{
    public class ShippingAddressReadRepository : ReadRepository<ShippingAddress>, IShippingAddressReadRepository
    {
        public ShippingAddressReadRepository(EcommerceAPIDbContext context) : base(context)
        {
        }
    }
}

