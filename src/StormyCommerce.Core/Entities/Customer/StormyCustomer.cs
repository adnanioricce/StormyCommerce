using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Models.Dtos;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Customer
{    
    public class StormyCustomer : IdentityUser<string>,IEntityWithBaseTypeId<string>
    {
        public StormyCustomer(){}

        public StormyCustomer(string id)
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
        public string CPF { get; set; }             
        public List<CustomerAddress> Addresses { get; set; } = new List<CustomerAddress>();
        public CustomerAddress DefaultShippingAddress { get; set; }
        public long? DefaultShippingAddressId { get; set; }
        public CustomerAddress DefaultBillingAddress { get; set; }
        public long? DefaultBillingAddressId { get; set; }
        public long? CustomerReviewsId { get; set; }
        public List<Review> CustomerReviews { get; set; } = new List<Review>();        
        public long? CustomerWishlistId { get; set; }                
        // public Phone Phone { get; set; }
        public string FullName { get; set; }        
        public string RefreshTokenHash { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }                        
        public List<ApplicationRole> Roles { get; set; }
        public DateTimeOffset CreatedOn { get; set; }        
    }
}
