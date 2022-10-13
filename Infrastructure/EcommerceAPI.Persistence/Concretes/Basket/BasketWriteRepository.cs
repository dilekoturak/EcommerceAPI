using System;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Persistence.Contexts;
using EcommerceAPI.Persistence.Repositories;

namespace EcommerceAPI.Persistence.Concretes
{
    public class BasketWriteRepository : WriteRepository<Basket>, IBasketWriteRepository
    {
        public BasketWriteRepository(EcommerceAPIDbContext context) : base(context)
        {
        }
    }
}

