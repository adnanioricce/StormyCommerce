﻿using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Domain.Customer
{
    public interface ICustomerService
    {
        Task CreateCustomerReviewAsync(Review review, string normalizedEmail);

        Task AddCustomerAddressAsync(CustomerAddress address, long customerIds);

        Task<IList<Review>> GetCustomerReviewsAsync(long customerId);

        Task<Review> GetCustomerReviewByIdAsync(string customerId, long? reviewId);

        Task<IList<CustomerAddress>> GetAllCustomerAddressByIdAsync(long id);
        
        Task<IList<StormyCustomer>> GetAllCustomersAsync();
        Task<IList<StormyCustomer>> GetAllCustomersAsync(long minLimit,long maxLimit);
        int GetCustomersCount();
        Task<StormyCustomer> GetCustomerByIdAsync(long id);

        Task<StormyCustomer> GetCustomerByUserNameOrEmail(string username, string email);

        Task EditCustomerReviewAsync(Review review, long customerId);

        Task EditCustomerReviewAsync(Review review, StormyCustomer customer);

        Task DeleteCustomerReviewByIdAsync(long reviewId, long customerId);

        Task CreateCustomerAsync(StormyCustomer customer);

        Task CreateCustomerAsync(CustomerDto appUser);

        Task EditCustomerAsync(CustomerDto customer);

        Task DeleteCustomerByIdAsync(long id);

        // Task
    }
}
