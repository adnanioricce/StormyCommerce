using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Models.Dtos;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Customer
{
    //TODO:Completely get rid of AppUser dependency. You can implement your own types https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/identity-custom-storage-providers?view=aspnetcore-2.2#customize-the-user-class
    public class StormyCustomer : BaseEntity
    {
        public StormyCustomer(){}

        public StormyCustomer(long id)
        {
            Id = id;
        }

        public StormyCustomer(CustomerDto customerDto)
        {
            CPF = customerDto.CPF;
            Email = customerDto.Email;
            PhoneNumber = customerDto.PhoneNumber;
            UserName = customerDto.UserName;
            FullName = customerDto.FullName;
            DefaultBillingAddress = customerDto.DefaultBillingAddress;
            DefaultShippingAddress = customerDto.DefaultShippingAddress;            
        }
        
        public string UserId { get; set; }
        public string CPF { get; set; }
        public string NormalizedEmail { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool EmailConfirmed { get; set; }        
        public List<CustomerAddress> Addresses { get; set; } = new List<CustomerAddress>();
        public CustomerAddress DefaultShippingAddress { get; set; }
        public long? DefaultShippingAddressId { get; set; }
        public CustomerAddress DefaultBillingAddress { get; set; }
        public long? DefaultBillingAddressId { get; set; }
        public long? CustomerReviewsId { get; set; }
        public IList<Review> CustomerReviews { get; set; } = new List<Review>();
        // public IList<StormyOrder> Orders { get; set; } = new List<StormyOrder>();
        public long? CustomerWishlistId { get; set; }
        public Wishlist CustomerWishlist { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string RefreshTokenHash { get; set; }
        public string Role { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
