using System;
using EcommerceAPI.Domain.Entities.Common;
namespace EcommerceAPI.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}

