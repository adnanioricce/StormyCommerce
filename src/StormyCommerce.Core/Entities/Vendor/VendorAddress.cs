using System;
using System.Collections.Generic;
using StormyCommerce.Core.Entities.Common;

namespace StormyCommerce.Core.Entities.Vendor
{
    public class VendorAddress : EntityBaseWithTypedId<long>
    {   

        public virtual Address Address { get; set; }
        public string WhoReceives  { get; set;}
        public string PhoneNumber {get;set;}
        public virtual StormyVendor Owner { get; set; }
        
    }
}
