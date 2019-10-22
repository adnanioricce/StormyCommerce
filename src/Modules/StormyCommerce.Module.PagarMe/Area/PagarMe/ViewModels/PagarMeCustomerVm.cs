using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels
{
    public class PagarMeCustomerVm
    {        
        [Required]
        public string ExternalId { get; set; }        
        [Required]
        public int Type { get; set; }
        [Required]
        public string Country { get; set; } = "br";        
        [Required]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public List<string> PhoneNumbers { get; set; } = new List<string>();
        [DataType(DataType.Date)]
        public DateTime? BornAt { get; set; }
        [DataType(DataType.Date)]
        public DateTime? BirthDay { get; set; }
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateCreated { get; set; }
        [Required]
        public List<Document> Documents { get; set; }
        public BillingVm Billing { get; set; }
        public ShippingVm Shipping { get; set; }
    }
}
