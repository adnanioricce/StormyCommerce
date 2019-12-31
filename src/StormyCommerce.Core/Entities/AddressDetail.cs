using System;
using System.Collections.Generic;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models;

namespace StormyCommerce.Core.Entities.Common
{
    //TODO:Write validations
    public class AddressDetail : ValueObject
    {
        public AddressDetail() {}        
        public AddressDetail(string country,string state,string city,string district,string street,string firstAddress,string secondAddress,string postalCode,string number,string complement,string contactName,string phone)
        {            
            Street = street;
            AddressLine1 = firstAddress;
            AddressLine2 = secondAddress;
            City = city; 
            DistrictName = district;
            State = state;
            ZipCode = postalCode;
            Number = number;
            Complement = complement;
            CountryCode = country;
            
        }

        public string Street { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string City { get; private set; }
        public string DistrictName { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }        
        public string CountryCode { get; private set; }
        public Phone Phone { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is AddressDetail address &&
                   base.Equals(obj) &&
                   Street == address.Street &&
                   AddressLine1 == address.AddressLine1 &&
                   AddressLine2 == address.AddressLine2 &&
                   City == address.City &&
                   DistrictName == address.DistrictName &&
                   State == address.State &&
                   ZipCode == address.ZipCode &&
                   Number == address.Number &&
                   Complement == address.Complement &&
                   CountryCode == address.CountryCode;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(Street);
            hash.Add(AddressLine1);
            hash.Add(AddressLine2);
            hash.Add(City);
            hash.Add(DistrictName);
            hash.Add(State);
            hash.Add(ZipCode);
            hash.Add(Number);
            hash.Add(Complement);
            hash.Add(CountryCode);
            return hash.ToHashCode();
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Street; 
            yield return AddressLine1; 
            yield return AddressLine2; 
            yield return City; 
            yield return DistrictName; 
            yield return State; 
            yield return ZipCode;
            yield return Number;
            yield return Complement;
            yield return CountryCode; 
        }
    }
}
