using System;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Persistence.Contexts;
using EcommerceAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Persistence.Concretes
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(EcommerceAPIDbContext context) : base(context)
        {
        }
    }
}

