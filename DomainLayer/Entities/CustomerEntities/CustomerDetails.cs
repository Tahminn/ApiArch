using DomainLayer.Common;
using System;

namespace DomainLayer.Entities.CustomerEntities
{
    public class CustomerDetails : BaseEntity
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public DateTime DateCreated { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
