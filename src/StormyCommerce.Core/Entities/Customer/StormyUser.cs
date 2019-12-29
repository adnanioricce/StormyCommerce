using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.User;
using StormyCommerce.Core.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Entities.Customer
{    
    public class StormyUser : IdentityUser<long>, IEntityBaseWithTypedId<long>, IExtendableObject
    {
        public StormyUser(){}

        public StormyUser(long id)
        {
            Id = id;
        }

        public StormyUser(CustomerDto customerDto)
        {
            CPF = customerDto.CPF;
            Email = customerDto.Email;
            PhoneNumber = customerDto.PhoneNumber;
            UserName = customerDto.UserName;
            FullName = customerDto.FullName;                                             
        }
        public string UserGuid { get; set; }
        public string CPF { get; set; }                
        public long? CustomerReviewsId { get; set; }        
        public virtual ICollection<CustomerAddress> Addresses { get; set; } = new List<CustomerAddress>();        
        public virtual ICollection<Review> CustomerReviews { get; set; } = new List<Review>();                
        public virtual ICollection<UserRole> Roles { get; set; } = new List<UserRole>();
        public virtual ICollection<CustomerGroupUser> CustomerGroups { get; set; } = new List<CustomerGroupUser>();
        public virtual Wishlist CustomerWishlist { get; set; } = new Wishlist();
        public long? VendorId { get; set; }
        public string FullName { get; set; }                
        public string RefreshTokenHash { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }                        
        // public virtual ApplicationRole Role { get; set; }         
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset LastModified { get; set; } = DateTime.UtcNow;        
        public string Culture { get; set; }
        public string ExtensionData { get; set; }        
        public void RemoveAddress(long addressId)
        {
            this.Addresses.Remove(this.Addresses.FirstOrDefault(a => a.Id == addressId));
        }        
        public void RemoveRelations()
        {
            this.CustomerWishlist = null;
            this.Addresses = null;
            this.CustomerReviews = null;
            this.Roles = null;
            this.CustomerGroups = null;

        }
    }
}
