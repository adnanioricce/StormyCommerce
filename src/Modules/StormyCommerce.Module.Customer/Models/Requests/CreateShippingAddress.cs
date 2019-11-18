using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using StormyCommerce.Core.Entities.Common;

namespace StormyCommerce.Module.Customer.Models.Requests
{
    [Serializable]
    public class CreateShippingAddressRequest
    {
        [Required]
        public Address Address { get; set; }
        public string WhoReceives { get; set; }
        [Required]
        public bool IsBillingAddress { get; set; }

    }
}
