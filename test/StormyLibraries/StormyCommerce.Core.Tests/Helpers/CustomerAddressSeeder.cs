using StormyCommerce.Core.Entities.Customer;
using System;

namespace StormyCommerce.Core.Tests.Helpers
{
    public static class CustomerAddressSeeder
    {
        public static CustomerAddress GetCustomerAddressData()
        {
            return new CustomerAddress(1)
            {
                City = "São Paulo",
                State = "SP",
                PostalCode = "01001-000",
                Street = "Praça da Sé",
                Complement = "lado ímpar",
                Country = "Brasil",
                FirstAddress = "Sé",
                Number = "4002",
                PhoneNumber = "8922",                
                LastModified = DateTimeOffset.UtcNow,
                IsDeleted = false,
            };
        }
    }
}
