using StormyCommerce.Core.Entities.Common;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Customer
{    
    public class CustomerAddress : EntityWithBaseTypeId<long>
    {
        public CustomerAddress(){}
        public CustomerAddress(long id)
        {
            Id = id;
        }        
        
        public virtual Address Address { get; set; }
        public string WhoReceives { get; set; }        
        public bool IsDeleted { get; set; }
        public string UserId { get; set; }
        public virtual StormyCustomer Owner { get; set; }        

        
    }
}
