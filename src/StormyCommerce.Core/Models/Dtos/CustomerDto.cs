using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Models.Dtos
{
    public class CustomerDto
    {
        public CustomerDto(){}
        public CustomerDto(User customer)
        {
            UserName = customer.UserName;
            Email = customer.Email;
            CPF = customer.CPF;
            PhoneNumber = customer.PhoneNumber;
            FullName = customer.FullName;                        
            Addresses = customer.Addresses == null ? this.Addresses : customer.Addresses.Select(c => new CustomerAddressDto(c)).ToList();            
        }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public IList<CustomerAddressDto> Addresses { get; private set; } = new List<CustomerAddressDto>();                
        public string CPF { get; private set; }
        public string PhoneNumber { get; private set; }
        public string FullName { get; private set; }
        public bool EmailConfirmed { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }        
    }
}
