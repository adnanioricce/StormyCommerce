using System;

namespace StormyCommerce.Core.Entities
{
    public class CustomerGroupUser 
    {
        public long UserId { get; set; }

        public virtual User User { get; set; }

        public long CustomerGroupId { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }
    }
}
