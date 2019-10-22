using StormyCommerce.Core.Entities.Customer;
using System;

namespace StormyCommerce.Core.Tests.Helpers
{
    public static class CustomerAddressSeeder
    {
        public static CustomerAddress GetCustomerAddressData()
        {
            return new CustomerAddress(2)
            {
                Address = new Entities.Common.Address("br",
                "SP",
                "São Paulo",
                "Sé",                
                "Praça da Sé",                
                "Vila alguma coisa",
                "rua doutor sem nome",
                "01001-000",
                "4002",
                "lado ímpar")                                   
            };
        }
    }
}
