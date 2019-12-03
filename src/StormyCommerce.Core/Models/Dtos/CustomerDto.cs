using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Models.Dtos
{
    public class CustomerDto
    {
        public CustomerDto(){}
        public CustomerDto(StormyCustomer customer)
        {
            UserName = customer.UserName;
            Email = customer.Email;
            CPF = customer.CPF;
            PhoneNumber = customer.PhoneNumber;
            FullName = customer.FullName;            
            CustomerWishlist = new WishlistDto(customer.CustomerWishlist);
            Addresses = customer.Addresses == null ? this.Addresses : customer.Addresses.Select(c => new CustomerAddressDto(c)).ToList();
            CustomerReviews = customer.CustomerReviews.Select(r => new CustomerReviewDto(r)).ToList();
        }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public IList<CustomerAddressDto> Addresses { get; private set; } = new List<CustomerAddressDto>();        
        public List<CustomerReviewDto> CustomerReviews { get; private set; } = new List<CustomerReviewDto>();
        public string CPF { get; private set; }
        public string PhoneNumber { get; private set; }
        public string FullName { get; private set; }
        public bool EmailConfirmed { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public WishlistDto CustomerWishlist { get; set; }
    }
}
