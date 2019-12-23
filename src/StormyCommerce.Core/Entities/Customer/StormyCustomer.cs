﻿using Microsoft.AspNetCore.Identity;
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
        }                
        public string CPF { get; set; }
        public virtual List<CustomerAddress> Addresses { get; set; } = new List<CustomerAddress>();        
        public long? CustomerReviewsId { get; set; }
        public virtual List<Review> CustomerReviews { get; set; } = new List<Review>();                
        public virtual Wishlist CustomerWishlist { get; set; } = new Wishlist();
        public string FullName { get; set; }        
        public string RefreshTokenHash { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }                        
        public virtual ApplicationRole Role { get; set; } 
        public DateTimeOffset CreatedOn { get; set; }
        
        public void RemoveAddress(long addressId)
        {
            this.Addresses.Remove(this.Addresses.FirstOrDefault(a => a.Id == addressId));
        }        
        public void RemoveRelations()
        {
            this.CustomerWishlist = null;
            this.Addresses = null;
            this.CustomerReviews = null;
            this.Role = null;
        }
    }
}
