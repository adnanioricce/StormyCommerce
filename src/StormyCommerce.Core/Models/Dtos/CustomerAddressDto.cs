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
            Address = address == null ? this.Address : new AddressDetail(address.Details.CountryCode,address.Details.State,address.Details.City,address.Details.DistrictName,address.Details.Street,address.Details.AddressLine1,address.Details.AddressLine2,address.Details.ZipCode,address.Details.Number,address.Details.Complement,"","");
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
