using StormyCommerce.Core.Entities.Common;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Customer
{    
    public class CustomerAddress : EntityBaseWithTypedId<long>
    {
        public CustomerAddress(){}
        public CustomerAddress(long id)
        {
            Id = id;
        }
        public CustomerAddress(Common.AddressDetail address)
        {
            this.Details = new Common.AddressDetail(address.CountryCode, address.State, address.City, address.DistrictName, address.Street, address.AddressLine1, address.AddressLine2, address.ZipCode, address.Number, address.Complement,"","");            
        }
        public virtual AddressDetail Details { get; set; }        
        public AddressType Type { get; set; }        
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        public string StormyCustomerId { get; set; }
        public virtual StormyCustomer Owner { get; set; }
        public DateTimeOffset? LastUsedOn { get; set; }

        public void SetAddress(Common.AddressDetail address)
        {
            this.Details = new Common.AddressDetail(address.CountryCode, address.State, address.City, address.DistrictName, address.Street, address.AddressLine1, address.AddressLine2, address.ZipCode, address.Number, address.Complement, "", "");            
        }
    }
}
