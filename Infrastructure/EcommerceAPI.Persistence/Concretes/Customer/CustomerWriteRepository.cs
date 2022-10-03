using System;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using EcommerceAPI.Persistence.Contexts;
using EcommerceAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Persistence.Concretes
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(EcommerceAPIDbContext context) : base(context)
        {
        }
    }
}

