using System;
using System.Collections.Generic;
using StormyCommerce.Core.Entities.Common;

namespace StormyCommerce.Core.Entities
{
    public class VendorAddress : EntityBaseWithTypedId<long>
    {   
        public virtual AddressDetail Address { get; set; }
        public string WhoReceives  { get; set;}
        public string PhoneNumber {get;set;}
        public virtual Vendor Owner { get; set; }
        
    }
}
