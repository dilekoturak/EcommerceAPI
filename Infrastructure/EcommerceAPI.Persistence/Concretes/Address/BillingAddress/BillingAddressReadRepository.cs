using System;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Persistence.Contexts;
using EcommerceAPI.Persistence.Repositories;

namespace EcommerceAPI.Persistence.Concretes
{
    public class BillingAddressReadRepository : ReadRepository<BillingAddress>, IBillingAddressReadRepository
    {
        public BillingAddressReadRepository(EcommerceAPIDbContext context) : base(context)
        {
        }
    }
}

