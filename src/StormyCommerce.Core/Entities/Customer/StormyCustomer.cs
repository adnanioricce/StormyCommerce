using StormyCommerce.Core.Entities.Common;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Customer
{
    //TODO:Completely get rid of AppUser dependency. You can implement your own types https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/identity-custom-storage-providers?view=aspnetcore-2.2#customize-the-user-class
    public class StormyCustomer : BaseEntity
    {
        public StormyCustomer() { }
        public StormyCustomer(long id)
        {
            Id = id;
        }
        public string UserId { get; set; }        
        public string CPF { get; set; }
        public string NormalizedEmail { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool EmailConfirmed { get; set; }
        public IList<Address> CustomerAddresses { get; set; } = new List<Address>();
        public Address DefaultShippingAddress { get; set; }
        public long? DefaultShippingAddressId { get; set; }
        public Address DefaultBillingAddress { get; set; }        
        public long? DefaultBillingAddressId { get; set; }        
        public long CustomerReviewsId { get; set; }
        public IList<Review> CustomerReviews { get; set; }        
        public long CustomerWishlistId { get; set; }              
        public Wishlist CustomerWishlist { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }                                
        public DateTimeOffset CreatedOn { get; set; }                 
    }
}
