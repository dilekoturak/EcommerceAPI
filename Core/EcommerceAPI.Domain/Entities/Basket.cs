using System;
using EcommerceAPI.Domain.Entities.Common;

namespace EcommerceAPI.Domain.Entities
{
    public class Basket : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public ICollection<Product> Products { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public BillingAddress BillingAddress { get; set; }
    }
}

