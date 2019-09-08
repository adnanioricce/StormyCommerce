using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Models.Dtos;

namespace StormyCommerce.Core.Interfaces.Domain.Customer
{
    public interface ICustomerService
    {
        Task CreateCustomerReviewAsync(CustomerReviewDto reviewDto);
        Task AddCustomerAddressAsync(Address address,long customerIds);
        Task<IList<Review>> GetCustomerReviewsAsync(long customerId);
        Task<Review> GetCustomerReviewByIdAsync(long customerId,long reviewId);
        Task<IList<Address>> GetAllCustomerAddressByIdAsync(long id);
        Task<IList<StormyOrder>> GetAllCustomerOrdersByIdAsync(long id);
        Task<IList<Payment>> GetAllCustomerPaymentsByIdAsync(long id);        
        Task EditCustomerReviewAsync(Review review);
        Task DeleteCustomerReviewByIdAsync(long id);
        Task CreateCustomerAsync(StormyCustomer customer);
        Task CreateCustomerAsync(CustomerDto appUser);
        Task EditCustomerAsync(CustomerDto customer);
        Task DeleteCustomerByIdAsync(long id);                
        // Task 
        
    }
}
