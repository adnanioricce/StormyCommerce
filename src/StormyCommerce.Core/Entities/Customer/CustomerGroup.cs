using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Customer
{
    public class CustomerGroup : EntityBase
    {
        public CustomerGroup()
        {
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
        }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }        

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset LatestUpdatedOn { get; set; }

        public virtual ICollection<CustomerGroupUser> Users { get; set; } = new List<CustomerGroupUser>();
    }
}
