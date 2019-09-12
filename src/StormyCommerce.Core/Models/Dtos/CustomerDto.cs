using StormyCommerce.Core.Entities.Common;
using System.Collections.Generic;

namespace StormyCommerce.Core.Models.Dtos
{
    public class CustomerDto
    {
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public IList<Address> CustomerAddresses { get; private set; }
        public Address DefaultBillingAddress { get; private set; }
        public Address DefaultShippingAddress { get; private set; }
        public string CPF { get; private set; }
        public string PhoneNumber { get; private set; }
        public string FullName { get; private set; }
    }
}
