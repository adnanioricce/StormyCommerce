using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Core.Models.Dtos
{
    public class CustomerAddressDto
    {
        public CustomerAddressDto(){}
        public CustomerAddressDto(CustomerAddress address)
        {
            Id = address.Id;
            Address = address == null ? this.Address : new AddressDetail(address.Country,address.State,address.City,address.District,address.Street,address.FirstAddress,address.SecondAddress,address.PostalCode,address.PostalCode,address.Complement,"","");
            WhoReceives = address == null ? this.WhoReceives : address.WhoReceives; 
            Owner = address.Owner == null ? this.Owner : new CustomerDto(address.Owner);
            IsDefault = address.IsDefault;
            Type = address.Type;
        }
        public long Id { get; private set; }
        public AddressDetail Address { get; private set; } = new AddressDetail();
        public AddressType Type { get; private set; }
        public bool IsDefault { get; private set; }
        public string WhoReceives { get; private set; }
        public CustomerDto Owner { get; private set; } = new CustomerDto();
    }
}
