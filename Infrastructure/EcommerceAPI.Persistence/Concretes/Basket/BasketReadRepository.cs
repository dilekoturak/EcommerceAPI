using System;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Persistence.Contexts;
using EcommerceAPI.Persistence.Repositories;

namespace EcommerceAPI.Persistence.Concretes
{
    public class BasketReadRepository : ReadRepository<Basket>, IBasketReadRepository
    {
        public BasketReadRepository(EcommerceAPIDbContext context) : base (context)
        {
        }
    }
}

