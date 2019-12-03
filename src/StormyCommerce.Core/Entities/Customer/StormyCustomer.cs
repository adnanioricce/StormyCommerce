using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

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
            //DefaultBillingAddress = customerDto.DefaultBillingAddress;
            //DefaultShippingAddress = customerDto.DefaultShippingAddress;         
            
               
        }                
        public string CPF { get; set; }
        public virtual List<CustomerAddress> Addresses { get; set; } = new List<CustomerAddress>();
        //public virtual CustomerAddress DefaultShippingAddress { get; set; } = new CustomerAddress();
        //public long? DefaultShippingAddressId { get; set; }
        //public virtual CustomerAddress DefaultBillingAddress { get; set; } = new CustomerAddress();
        //public long? DefaultBillingAddressId { get; set; }
        public long? CustomerReviewsId { get; set; }
        public virtual List<Review> CustomerReviews { get; set; } = new List<Review>();        
        public long? CustomerWishlistId { get; set; }
        public virtual Wishlist CustomerWishlist { get; set; } = new Wishlist();
        public string FullName { get; set; }        
        public string RefreshTokenHash { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }                        
        public virtual ApplicationRole Role { get; set; } 
        public DateTimeOffset CreatedOn { get; set; }

        //public bool AddDefaultBillingAddress(CustomerAddress address)
        //{
        //    //if(this.Addresses.Any(a => a.))
        //}
        public void RemoveAddress(long addressId)
        {
            this.Addresses.Remove(this.Addresses.FirstOrDefault(a => a.Id == addressId));
        }
    }
}
