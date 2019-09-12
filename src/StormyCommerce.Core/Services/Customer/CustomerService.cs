using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Customer;
using StormyCommerce.Core.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var customer = _customerRepository.Table.First(c => c.Email == reviewDto.Email);
            var review = new Review(reviewDto);
            review.StormyCustomerId = customer.Id;
            review.Author = customer;
            customer.CustomerReviews.Add(review);
            await _customerRepository.UpdateAsync(customer);
        }

        public async Task<IList<Review>> GetCustomerReviewsAsync(long customerId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);
            return customer.CustomerReviews;
        }

        public async Task<Review> GetCustomerReviewByIdAsync(long customerId, long reviewId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);
            return customer.CustomerReviews.FirstOrDefault(r => r.Id == reviewId);
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

        public async Task<IList<StormyOrder>> GetAllCustomerOrdersByIdAsync(long id)
        {
            // var customer = await _customerRepository.GetByIdAsync(id);            
            throw new NotImplementedException();
        }

        public async Task<IList<Payment>> GetAllCustomerPaymentsByIdAsync(long id)
        {
            // var customer = await _customerRepository.GetByIdAsync(id);
            throw new NotImplementedException();
        }

        public async Task CreateCustomerAsync(StormyCustomer customer)
        {
            await _customerRepository.AddAsync(customer);
        }

        public async Task CreateCustomerAsync(CustomerDto appUser)
        {
            var customer = new StormyCustomer(appUser);
            await _customerRepository.AddAsync(customer);
        }

        public async Task EditCustomerAsync(CustomerDto customer)
        {
            await _customerRepository.UpdateAsync(new StormyCustomer(customer));
        }

        public async Task DeleteCustomerByIdAsync(long id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            customer.IsDeleted = true;
            await _customerRepository.UpdateAsync(customer);
        }

        public async Task AddCustomerAddressAsync(Address address, long customerId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);
            customer.CustomerAddresses.Add(address);
            await _customerRepository.UpdateAsync(customer);
        }
    }
}
