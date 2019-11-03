using System;
using System.Collections.Generic;
using StormyCommerce.Core.Models;

namespace StormyCommerce.Core.Entities.Common
{
    //TODO:Write validations
    public class Address : ValueObject
    {
        public Address() {}        
        public Address(string country,string state,string city,string district,string street,string firstAddress,string secondAddress,string postalCode,string number,string complement)
        {            
            Street = street;
            FirstAddress = firstAddress;
            SecondAddress = secondAddress;
            City = city; 
            District = district;
            State = state;
            PostalCode = postalCode;
            Number = number;
            Complement = complement;
            Country = country;
        }

        public string Street { get; private set; }
        public string FirstAddress { get; private set; }
        public string SecondAddress { get; private set; }
        public string City { get; private set; }
        public string District { get; private set; }
        public string State { get; private set; }
        public string PostalCode { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }        
        public string Country { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is Address address &&
                   base.Equals(obj) &&
                   Street == address.Street &&
                   FirstAddress == address.FirstAddress &&
                   SecondAddress == address.SecondAddress &&
                   City == address.City &&
                   District == address.District &&
                   State == address.State &&
                   PostalCode == address.PostalCode &&
                   Number == address.Number &&
                   Complement == address.Complement &&
                   Country == address.Country;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(Street);
            hash.Add(FirstAddress);
            hash.Add(SecondAddress);
            hash.Add(City);
            hash.Add(District);
            hash.Add(State);
            hash.Add(PostalCode);
            hash.Add(Number);
            hash.Add(Complement);
            hash.Add(Country);
            return hash.ToHashCode();
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Street; 
            yield return FirstAddress; 
            yield return SecondAddress; 
            yield return City; 
            yield return District; 
            yield return State; 
            yield return PostalCode;
            yield return Number;
            yield return Complement;
            yield return Country; 
        }
    }
}
