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
            this.SetAddress(address);
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
        public bool IsDeleted { get; set; }
        public string UserId { get; set; }
        public virtual StormyCustomer Owner { get; set; }

        public void SetAddress(Address address)
        {
            PostalCode = address.PostalCode;
            District = address.District;
            Number = address.Number;
            FirstAddress = address.FirstAddress;
            SecondAddress = address.SecondAddress;
            State = address.State;
            Street = address.Street;
            Country = address.Country;
            Complement = address.Complement;
            City = address.City;
        }
    }
}
