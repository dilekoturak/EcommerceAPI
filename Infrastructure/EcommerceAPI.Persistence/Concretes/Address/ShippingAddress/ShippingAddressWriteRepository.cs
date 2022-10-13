using System;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Persistence.Contexts;
using EcommerceAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Persistence.Concretes
{
    public class ShippingAddressWriteRepository : WriteRepository<ShippingAddress>, IShippingAddressWriteRepository
    {
        public ShippingAddressWriteRepository(EcommerceAPIDbContext context) : base(context)
        {
        }
    }
}

