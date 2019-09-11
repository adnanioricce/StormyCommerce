using Microsoft.EntityFrameworkCore;
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
            var customer = await _customerRepository.Table.Include(r => r.CustomerReviews).FirstOrDefaultAsync(f => f.Email == reviewDto.Email || f.UserName == reviewDto.UserName);
            // if(customer.CustomerReviews == null)
            // throw new ArgumentNullException();
            customer.CustomerReviews.Add(new Review(reviewDto));
            await _customerRepository.UpdateAsync(customer);
        }
        // public async Task CreateCustomerReviewAsync()
        // {

        // }
        public async Task<IList<Review>> GetCustomerReviewsAsync(long customerId)
        {
            return (await _customerRepository.Table            
            .Include(c => c.CustomerReviews)            
            .FirstOrDefaultAsync(f => f.Id == customerId)).CustomerReviews;
        }

        public async Task<Review> GetCustomerReviewByIdAsync(long customerId, long reviewId)
        {
            return await _reviewRepository.Table.FirstOrDefaultAsync(c => c.Id == reviewId && c.StormyCustomerId == customerId);            
        }

        public async Task EditCustomerReviewAsync(Review review)
        {
            await _reviewRepository.UpdateAsync(review);
        }

        public async Task DeleteCustomerReviewByIdAsync(long id)
        {
            var review = await _reviewRepository.GetByIdAsync(id);
            review.IsDeleted = true;
            await _reviewRepository.UpdateAsync(review);
        }

        public async Task<IList<Address>> GetAllCustomerAddressByIdAsync(long id)
        {
            return (await _customerRepository.Table.Include(a => a.CustomerAddresses).FirstOrDefaultAsync(c => c.Id == id)).CustomerAddresses;            
        }

        public Task<IList<StormyOrder>> GetAllCustomerOrdersByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Payment>> GetAllCustomerPaymentsByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task CreateCustomerAsync(StormyCustomer customer)
        {
            await _customerRepository.AddAsync(customer);
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

        public async Task AddCustomerAddressAsync(Address address, long customerId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);
            customer.CustomerAddresses.Add(address);
            await _customerRepository.UpdateAsync(customer);
        }
    }
}
