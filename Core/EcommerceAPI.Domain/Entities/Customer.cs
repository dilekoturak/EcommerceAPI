using System;
using EcommerceAPI.Domain.Entities.Common;
namespace EcommerceAPI.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<BillingAddress> BillingAddresses { get; set; }
        public ICollection<ShippingAddress> ShippingAddresses { get; set; }
        public Basket Basket { get; set; }
    }
}

