﻿using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using System.Collections.Generic;

namespace StormyCommerce.Core.Models.Dtos
{
    public class CustomerDto
    {
        public CustomerDto(){}
        public CustomerDto(StormyCustomer customer)
        {
            UserName = customer.UserName;
            Email = customer.Email;
            CPF = customer.CPF;
            PhoneNumber = customer.PhoneNumber;
            FullName = customer.FullName;
        }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public IList<CustomerAddress> CustomerAddresses { get; private set; }
        public CustomerAddress DefaultBillingAddress { get; private set; }
        public CustomerAddress DefaultShippingAddress { get; private set; }
        public string CPF { get; private set; }
        public string PhoneNumber { get; private set; }
        public string FullName { get; private set; }
    }
}
