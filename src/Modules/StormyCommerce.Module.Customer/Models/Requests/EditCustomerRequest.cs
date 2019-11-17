using System;

namespace StormyCommerce.Module.Customer.Models.Requests
{
    [Serializable]
    public class EditCustomerRequest
    {
        public string CPF { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
    }
}
