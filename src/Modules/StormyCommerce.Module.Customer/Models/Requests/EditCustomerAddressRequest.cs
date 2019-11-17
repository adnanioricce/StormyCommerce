using System;
using StormyCommerce.Core.Entities.Common;

namespace StormyCommerce.Module.Customer.Models.Requests
{
    [Serializable]
    public class EditCustomerAddressRequest
    {
        public Address Address { get; set; }
        public string WhoReceives { get; set; }
    }
}
