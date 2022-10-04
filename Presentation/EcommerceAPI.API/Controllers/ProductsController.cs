using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceAPI.Application.Abstractions;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EcommerceAPI.API.Controllers
{

    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;

        public ProductsController(
            IProductWriteRepository productWriteRepository,
            IProductReadRepository productReadRepository,
            IOrderWriteRepository orderWriteRepository,
            ICustomerWriteRepository customerWriteRepository,
            IOrderReadRepository orderReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //cmd shift /
            // Test 1
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 100, CreatedDate = DateTime.UtcNow, Stock = 10 },
            //    new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 200, CreatedDate = DateTime.UtcNow, Stock = 20 },
            //    new() { Id = Guid.NewGuid(), Name = "Product 3", Price = 300, CreatedDate = DateTime.UtcNow, Stock = 30 },
            //});
            //var count = await _productWriteRepository.SaveAsync();

            //------------------------------------------------------
            // Test 2
            //tracking'i kapattık, DBye yansımayacak.
            //Product p = await _productReadRepository.GetByIdAsync("4fa8d52b-aa13-44c7-a6c8-a23b9c2a4626", false);
            //p.Name = "Dilek";
            //await _productWriteRepository.SaveAsync();

            //-------------------------------------------------------
            // Test 3
            //await _productWriteRepository.AddAsync(new()
            //{
            //    Name = "C Product",
            //    Price = 1.500F,
            //    Stock = 10,
            //    CreatedDate = DateTime.UtcNow
            //});
            //await _productWriteRepository.SaveAsync();

            // Test 4
            //var customerId = Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() { Id = customerId, Name = "Dilek" });
            //await _orderWriteRepository.AddAsync(new() { Description = "bla bla bla", Address = "Izmir", CustomerId = customerId });
            //await _orderWriteRepository.AddAsync(new() { Description = "bla2 bla2 bla2", Address = "Balikesir", CustomerId = customerId });
            //await _orderWriteRepository.SaveAsync();

            //Test 5
            Order order = await _orderReadRepository.GetByIdAsync("692d9609-7f49-420f-b074-8cb7205d79f8");
            order.Address = "Istanbul";
            await _orderWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }

    }
}

