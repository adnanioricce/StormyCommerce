using System.Collections.Generic;
using StormyCommerce.Core.Entities.Common;

namespace StormyCommerce.Core.Models.Dtos
{
    public class CustomerDto
    {        
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public IList<Address>  CustomerAddresses{ get; private set; }
        public Address DefaultBillingAddress { get; private set; }
        public Address DefaultDestinationAddress { get; private set; }
        public string CPF { get; private set; }        
    }
}