using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Entities
{    
    public class User : IdentityUser<long>, IEntityBaseWithTypedId<long>, IExtendableObject
    {
        public User(){}

        public User(long id)
        {
            Id = id;
        }

        public User(CustomerDto customerDto)
        {
            CPF = customerDto.CPF;
            Email = customerDto.Email;
            PhoneNumber = customerDto.PhoneNumber;
            UserName = customerDto.UserName;
            FullName = customerDto.FullName;                                             
        }
        public const string SettingsDataKey = "Settings";
        public string UserGuid { get; set; }
        public string CPF { get; set; }                
        public long? CustomerReviewsId { get; set; }        
        public virtual ICollection<CustomerAddress> Addresses { get; set; } = new List<CustomerAddress>();                
        public virtual ICollection<UserRole> Roles { get; set; } = new List<UserRole>();
        public virtual ICollection<CustomerGroupUser> CustomerGroups { get; set; } = new List<CustomerGroupUser>();        
        public long? VendorId { get; set; }
        public string FullName { get; set; }                
        public string RefreshTokenHash { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }                        
        // public virtual ApplicationRole Role { get; set; }         
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset LastModified { get; set; } = DateTime.UtcNow;        
        public string Culture { get; set; }
        public string ExtensionData { get; set; }
        public bool IsDeleted { get; set; }
        public void RemoveAddress(long addressId)
        {
            this.Addresses.Remove(this.Addresses.FirstOrDefault(a => a.Id == addressId));
        }        
        public void RemoveRelations()
        {            
            this.Addresses = null;            
            this.Roles = null;
            this.CustomerGroups = null;

        }
    }
}
