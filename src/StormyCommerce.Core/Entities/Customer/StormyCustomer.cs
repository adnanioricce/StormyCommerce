using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Customer
{
    //TODO:Completely get rid of AppUser dependency. You can implement your own types https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/identity-custom-storage-providers?view=aspnetcore-2.2#customize-the-user-class
    public class StormyCustomer : BaseEntity
    {
        public string UserId { get; set; }
        public string CPF { get; set; }
        public IList<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();
        public CustomerAddress DefaultShippingAddress { get; set; }
        public long? DefaultShippingAddressId { get; set; }
        public CustomerAddress DefaultBillingAddress { get; set; }
        public long? DefaultBillingAddressId { get; set; }                      
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }                        
        public DateTimeOffset CreatedOn { get; set; }                 
    }
}
