// using System.Collections.Generic;
// using StormyCommerce.Core.Entities.Common;
// using StormyCommerce.Core.Entities.Customer;

// namespace StormyCommerce.Core.Entities.Address
// {
//     public class Address : EntityBase
//     {
//         public Address() { }

//         public Address(long id)
//         {
//             Id = id;
//         }
//         public AddressDetail Detail { get; set; }        
//         public string ContactName { get; set; }        
//         public string Phone { get; set; }        
//         public long? DistrictId { get; set; }
//         public District District { get; set; }        
//         public long StateOrProvinceId { get; set; }
//         public StateOrProvince StateOrProvince { get; set; }        
//         public string CountryId { get; set; }
//         public Country Country { get; set; }
//         public ICollection<CustomerAddress> UserAddresses { get; set; } = new List<CustomerAddress>();
//     }
// }
