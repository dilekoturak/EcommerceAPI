using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    public class BillingAddressController : ControllerBase
    {
        readonly private IBillingAddressReadRepository _billingAddressReadRepository;
        readonly private IBillingAddressWriteRepository _billingAddressWriteRepository;

        public BillingAddressController(
                                IBillingAddressReadRepository billingAddressReadRepository,
                                IBillingAddressWriteRepository billingAddressWriteRepository
            )
        {
            _billingAddressReadRepository = billingAddressReadRepository;
            _billingAddressWriteRepository = billingAddressWriteRepository;
        }

        [HttpPost("{customerId}")]
        public async Task<IActionResult> AddBillingAddress(Guid customerId)
        {
            await _billingAddressWriteRepository.AddAsync(new()
            {
                Id = Guid.NewGuid(),
                CustomerId = customerId,
                Address = "Billing Address 1",
                City = "Izmir",
                Country = "Turkey",
                PostalCode = 35000
            });
            await _billingAddressWriteRepository.SaveAsync();

            return Ok();
        }

        [HttpGet("GetBillingAddresses/{customerId}")]
        public IList<BillingAddress> GetBillingAddresses(Guid customerId)
        {
            IList<BillingAddress> billingAddresses = _billingAddressReadRepository.GetWhere(data => data.CustomerId == customerId).ToList();
            return billingAddresses;
        }
    }
}

