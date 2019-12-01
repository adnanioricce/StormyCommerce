﻿using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Core.Models.Dtos
{
    public class CustomerAddressDto
    {
        public CustomerAddressDto(){}
        public CustomerAddressDto(CustomerAddress address)
        {
            Address = address == null ? this.Address : new Address(address.Country,address.State,address.City,address.District,address.Street,address.FirstAddress,address.SecondAddress,address.PostalCode,address.PostalCode,address.Complement);
            WhoReceives = address == null ? this.WhoReceives : address.WhoReceives; 
            Owner = address.Owner == null ? this.Owner : new CustomerDto(address.Owner);
        }
        public long Id { get; private set; }
        public Address Address { get; private set; } = new Address();
        public AddressType Type { get; private set; }
        public bool IsDefault { get; private set; }
        public string WhoReceives { get; private set; }
        public CustomerDto Owner { get; private set; } = new CustomerDto();
    }
}
