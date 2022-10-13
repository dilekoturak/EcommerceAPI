using System;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    public class ShippingAddressController : ControllerBase
    {
        readonly private IShippingAddressReadRepository _shippingAddressReadRepository;
        readonly private IShippingAddressWriteRepository _shippingAddressWriteRepository;

        public ShippingAddressController(IShippingAddressReadRepository shippingAddressReadRepository,
                                IShippingAddressWriteRepository shippingAddressWriteRepository)
        {
            _shippingAddressReadRepository = shippingAddressReadRepository;
            _shippingAddressWriteRepository = shippingAddressWriteRepository;
        }

        [HttpPost("{customerId}")]
        public async Task<IActionResult> AddShippingAddress(Guid customerId)
        {
            await _shippingAddressWriteRepository.AddAsync(new()
            {
                Id = Guid.NewGuid(),
                Address = "Address 2",
                CustomerId = customerId,
                City = "Balikesir",
                Country = "Turkey",
                PostalCode = 35000
            });
            await _shippingAddressWriteRepository.SaveAsync();

            return Ok();
        }

        [HttpGet("GetShippingAddresses/{customerId}")]
        public IList<ShippingAddress> GetShippingAddresses(Guid customerId)
        {
            IList<ShippingAddress> shippingAddresses = _shippingAddressReadRepository.GetWhere(data => data.CustomerId == customerId).ToList();
            return shippingAddresses;
        }
    }
}

