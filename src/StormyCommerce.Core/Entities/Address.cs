using System.Collections.Generic;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Core.Entities.Address
{
    public class Address : EntityBase
    {
        public Address() { }

        public Address(long id)
        {
            Id = id;
        }
        public virtual AddressDetail Detail { get; set; }        
        public string ContactName { get; set; }        
        public string Phone { get; set; }        
        public long? DistrictId { get; set; }
        public virtual District District { get; set; }        
        public long StateOrProvinceId { get; set; }
        public virtual StateOrProvince StateOrProvince { get; set; }        
        public string CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<CustomerAddress> UserAddresses { get; set; } = new List<CustomerAddress>();
    }
}
