using System;

namespace StormyCommerce.Core.Entities.Customer
{
    public class CustomerGroupUser 
    {
        public long UserId { get; set; }

        public StormyCustomer User { get; set; }

        public long CustomerGroupId { get; set; }

        public CustomerGroup CustomerGroup { get; set; }
    }
}
