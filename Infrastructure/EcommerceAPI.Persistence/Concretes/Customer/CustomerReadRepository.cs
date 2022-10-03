using System;
using System.Linq.Expressions;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Persistence.Contexts;
using EcommerceAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Persistence.Concretes
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(EcommerceAPIDbContext context) : base(context)
        {

        }
    }
}

