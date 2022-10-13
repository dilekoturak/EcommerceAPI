using System;
using EcommerceAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        readonly private ICustomerWriteRepository _customerWriteRepository;
        public CustomerController(ICustomerWriteRepository customerWriteRepository)
        {
            _customerWriteRepository = customerWriteRepository;
        }

        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddCustomer()
        {
            await _customerWriteRepository.AddAsync(new()
            {
                Id = Guid.NewGuid(),
                Name = "Dilek"
            });
            await _customerWriteRepository.SaveAsync();

            return Ok();
        }
    }
}

