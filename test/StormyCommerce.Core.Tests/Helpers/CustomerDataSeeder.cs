using StormyCommerce.Core.Entities.Customer;
using System;

namespace StormyCommerce.Core.Tests.Helpers
{
    public static class CustomerDataSeeder
    {
        private static readonly string sampleUserId = "F9159083-F4B4-4B01-97F1-AE670BC82205";

        public static StormyCustomer GetCustomerData()
        {
            return new StormyCustomer
            {
                UserName = "joaocraftgameplayshd",
                Email = "joaozinhogameplays@uol.com",
                CreatedOn = DateTimeOffset.UtcNow,
                CPF = "40028922",
                FullName = "Joao Arimateia Pinto",
                DefaultShippingAddress = CustomerAddressSeeder.GetCustomerAddressData(),
                DefaultShippingAddressId = 1,               
            };
        }
    }
}
