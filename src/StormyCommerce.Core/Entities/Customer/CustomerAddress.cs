using StormyCommerce.Core.Entities.Common;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Customer
{    
    public class CustomerAddress : EntityWithBaseTypeId<long>
    {
        public CustomerAddress(){}
        public CustomerAddress(long id)
        {
            Id = id;
        }
        public CustomerAddress(Address address)
        {
            this.PostalCode = address.PostalCode;
            this.District = address.District;
            this.Number = address.Number;
            this.FirstAddress = address.FirstAddress;
            this.SecondAddress = address.SecondAddress;
            this.State = address.State;
            this.Street = address.Street;
            this.Country = address.Country;
            this.Complement = address.Complement;
            this.City = address.City;
        }

        public string Street { get; set; }
        public string FirstAddress { get; set; }
        public string SecondAddress { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Country { get; set; }
        public string WhoReceives { get; set; }
        public AddressType Type { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        public string StormyCustomerId { get; set; }
        public virtual StormyCustomer Owner { get; set; }

        public void SetAddress(Address address)
        {
            this.PostalCode = address.PostalCode;
            this.District = address.District;
            this.Number = address.Number;
            this.FirstAddress = address.FirstAddress;
            this.SecondAddress = address.SecondAddress;
            this.State = address.State;
            this.Street = address.Street;
            this.Country = address.Country;
            this.Complement = address.Complement;
            this.City = address.City;
        }
    }
}
