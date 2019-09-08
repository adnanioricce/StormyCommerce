using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Payments;

namespace StormyCommerce.Core.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly IStormyRepository<Review> _reviewRepository;
        private readonly IStormyRepository<StormyCustomer> _customerRepository;        
        public CustomerService(IStormyRepository<Review> reviewRepository,
        IStormyRepository<StormyCustomer> customerRepository)
        {
            _reviewRepository = reviewRepository;
            _customerRepository = customerRepository;
        }

        public async Task CreateCustomerReviewAsync(CustomerReviewDto reviewDto)
        {
            throw new NotImplementedException();
        }
        public async Task<IList<Review>> GetCustomerReviewsAsync(long customerId)
        {
            throw new NotImplementedException();
        }
        public async Task<Review> GetCustomerReviewByIdAsync(long customerId,long reviewId)
        {
            throw new NotImplementedException();
        }
        public async Task EditCustomerReviewAsync(Review review)
        {
            throw new NotImplementedException();
        }
        public async Task DeleteCustomerReviewByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
        public Task<IList<Address>> GetAllCustomerAddressByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
        public Task<IList<StormyOrder>> GetAllCustomerOrdersByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
        public Task<IList<Payment>> GetAllCustomerPaymentsByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
        public Task CreateCustomerAsync(StormyCustomer customer)
        {
            throw new NotImplementedException();
        }
        public Task CreateCustomerAsync(CustomerDto appUser)
        {
            throw new NotImplementedException();
        }
        public Task EditCustomerAsync(CustomerDto customer)
        {
            throw new NotImplementedException();
        }
        public async Task DeleteCustomerByIdAsync(long id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            customer.IsDeleted = true;
            await _customerRepository.UpdateAsync(customer);
            
        }

        public async Task AddCustomerAddressAsync(Address address,long customerId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);
            customer.CustomerAddresses.Add(address);
            await _customerRepository.UpdateAsync(customer);            
        }
    }
}
