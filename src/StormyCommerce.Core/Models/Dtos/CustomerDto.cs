using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using System;
using System.Collections.Generic;

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
            DefaultBillingAddress = customer.DefaultBillingAddress ?? new CustomerAddress();
            DefaultShippingAddress = customer.DefaultShippingAddress ?? new CustomerAddress();
            CustomerWishlist = new WishlistDto(customer.CustomerWishlist);
            //Addresses = customer.Addresses ?? new List<CustomerAddress>();
        }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public IList<CustomerAddress> Addresses { get; private set; } = new List<CustomerAddress>();
        public CustomerAddress DefaultBillingAddress { get; private set; }
        public CustomerAddress DefaultShippingAddress { get; private set; }
        public List<CustomerReviewDto> CustomerReviews { get; private set; } = new List<CustomerReviewDto>();
        public string CPF { get; private set; }
        public string PhoneNumber { get; private set; }
        public string FullName { get; private set; }
        public bool EmailConfirmed { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public WishlistDto CustomerWishlist { get; set; }
    }
}
