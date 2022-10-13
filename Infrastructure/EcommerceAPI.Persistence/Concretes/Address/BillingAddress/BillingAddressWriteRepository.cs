using System;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Persistence.Contexts;
using EcommerceAPI.Persistence.Repositories;

namespace EcommerceAPI.Persistence.Concretes
{
    public class BillingAddressWriteRepository : WriteRepository<BillingAddress>, IBillingAddressWriteRepository
    {
        public BillingAddressWriteRepository(EcommerceAPIDbContext context) : base(context)
        {
        }
    }
}

