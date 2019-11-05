using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Core.Models.Dtos
{
    public class CustomerAddressDto
    {
        public CustomerAddressDto(){}
        public CustomerAddressDto(CustomerAddress address)
        {
            Address = address.Address;
            WhoReceives = address.WhoReceives; 
            Owner = new CustomerDto(address.Owner);
        }
        public Address Address { get; set; }
        public string WhoReceives { get; set; }
        public CustomerDto Owner { get; set; }
    }
}