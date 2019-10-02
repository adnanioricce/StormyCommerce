using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels
{
    public class PagarMeCustomerVm
    {
        public int Id { get; set; }
        public long ExternalId { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public string DocumentType { get; set; }
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string[] PhoneNumbers { get; set; }
        public DateTime? BornAt { get; set; }
        public string BirthDay { get; set; }
        public string Gender { get; set; }
        public string DateCreated { get; set; }
        public List<Document> Documents { get; set; }
        public BillingVm Billing { get; set; }
        public ShippingVm Shipping { get; set; }
    }
}
