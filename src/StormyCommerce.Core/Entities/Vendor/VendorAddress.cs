using System;
using System.Collections.Generic;
using StormyCommerce.Core.Entities.Common;

namespace StormyCommerce.Core.Entities.Vendor
{
    public class VendorAddress : EntityWithBaseTypeId<long>
    {   

        public Address Address { get; set; }
        public string WhoReceives  { get; set;}
        public string PhoneNumber {get;set;}
        public StormyVendor Owner { get; set; }
        
    }
}