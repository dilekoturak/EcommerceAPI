using System;
using EcommerceAPI.Domain.Entities;

namespace EcommerceAPI.Application.Abstractions
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}

