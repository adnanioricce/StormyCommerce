using StormyCommerce.Core.Entities.Common;
using System;

namespace StormyCommerce.Core.Entities.Customer
{
    public class CustomerAddress : BaseEntity
    {
        public long CustomerId { get; set; }
        public StormyCustomer Customer { get; set; }
        public long AddressId { get; set; }
        public Address Address { get; set; }        
        public DateTimeOffset? LastUsedOn { get; set; }
    }
}
