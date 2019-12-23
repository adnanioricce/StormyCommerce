using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Module.Customer.Models.Requests
{
    [Serializable]
    public class CreateShippingAddressRequest
    {
        [Required]
        public Address Address { get; set; }
        public string WhoReceives { get; set; }
        [Required]
        public AddressType Type { get; set; }
        public bool IsDefault { get; set; } = true;

    }
}
