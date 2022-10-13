using System;
using EcommerceAPI.Domain.Entities.Common;

namespace EcommerceAPI.Domain.Entities
{
    public class BillingAddress : BaseEntity
    {
        public string Address { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public Guid CustomerId { get; set; }
    }
}

