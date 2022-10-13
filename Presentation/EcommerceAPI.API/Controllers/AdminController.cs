using System;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;

        public AdminController(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }

        [HttpPost("AddProduct/product")]
        public async Task<IActionResult> AddProduct(Product product)
        {
            await _productWriteRepository.AddAsync(new()
            {
                Id = Guid.NewGuid(),
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock
            });
            await _productWriteRepository.SaveAsync();
            return Ok();
        }
    }
}

