using System;

namespace StormyCommerce.Core.Entities.Customer
{
    public class CustomerGroupUser 
    {
        public long UserId { get; set; }

        public virtual StormyUser User { get; set; }

        public long CustomerGroupId { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }
    }
}
