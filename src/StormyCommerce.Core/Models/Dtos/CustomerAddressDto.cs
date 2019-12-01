using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Core.Models.Dtos
{
    public class CustomerAddressDto
    {
        public CustomerAddressDto(){}
        public CustomerAddressDto(CustomerAddress address)
        {
            Address = new Address(address.Country,address.State,address.City,address.District,address.Street,address.FirstAddress,address.SecondAddress,address.PostalCode,address.PostalCode,address.Complement);
            WhoReceives = address.WhoReceives; 
            Owner = new CustomerDto(address.Owner);
        }
        public Address Address { get; set; } = new Address();
        public string WhoReceives { get; set; }
        public CustomerDto Owner { get; set; } = new CustomerDto();
    }
}
