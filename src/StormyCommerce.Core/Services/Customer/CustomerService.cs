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
        #region Create Operations
        public async Task CreateCustomerReviewAsync(Review review, string normalizedEmail)
        {
            var customer = await _customerRepository.Table
            .FirstOrDefaultAsync(f => f.Email.Equals(normalizedEmail));
            if (review == null) throw new ArgumentNullException("given review entity is null");
            if (customer == null) throw new ArgumentNullException("given customer is null");            
            customer.CustomerReviews.Add(review);
            await _customerRepository.UpdateAsync(customer);
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
        #endregion
        public async Task<IList<Review>> GetCustomerReviewsAsync(long customerId)
        {
            // _customerRepository.Table
            // .Include(c => c.CustomerReviews)
            // .Load();
            // return (await _customerRepository.Table.FirstOrDefaultAsync(f => f.Id == customerId)).CustomerReviews;
            var customer = await _customerRepository.Table
            .Include(c => c.CustomerReviews).FirstOrDefaultAsync(c => c.Id == customerId);
            return customer.CustomerReviews;
        }

        public async Task<Review> GetCustomerReviewByIdAsync(string customerId, long? reviewId)
        {
            return await _reviewRepository.GetByIdAsync(reviewId);            
        }

        public async Task EditCustomerReviewAsync(Review review, long customerId)
        {            
            var oldReview = await _reviewRepository.GetByIdAsync(review.Id) ?? throw new ArgumentNullException();
            oldReview.Comment = review.Comment;
            oldReview.RatingLevel = review.RatingLevel;
            oldReview.Status = review.Status;
            oldReview.Title = review.Title;
            oldReview.ReviewerName = review.ReviewerName;
            oldReview.IsDeleted = review.IsDeleted;
                        
            await _reviewRepository.UpdateAsync(oldReview);
        }

        public async Task DeleteCustomerReviewByIdAsync(long reviewId, long customerId)
        {            
            var review = await _reviewRepository.GetByIdAsync(reviewId);
            review.IsDeleted = true;
            await _reviewRepository.UpdateAsync(review);            
        }

        public async Task<IList<CustomerAddress>> GetAllCustomerAddressByIdAsync(long id)
        {
            return (await _customerRepository.Table.Include(a => a.Addresses).FirstOrDefaultAsync(c => c.Id == id)).Addresses;
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

        public async Task AddCustomerAddressAsync(CustomerAddress address, long customerId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);
            customer.Addresses.Add(address);
            await _customerRepository.UpdateAsync(customer);
        }

        public async Task<IList<StormyCustomer>> GetAllCustomersAsync()
        {
            _customerRepository.Table
            .Include(f => f.CustomerReviews)
            .Include(f => f.CustomerWishlist)
            .Include(f => f.DefaultBillingAddress)
            .Include(f => f.DefaultShippingAddress)            
            .Load();
            return await _customerRepository.GetAllAsync();
        }
        public async Task<IList<StormyCustomer>> GetAllCustomersAsync(long minLimit,long maxLimit)
        {
            //_customerRepository.Table
            
            //.Load();
            return await _customerRepository.Table
                .Include(f => f.CustomerReviews)
                .Include(f => f.CustomerWishlist)
                .Include(f => f.DefaultBillingAddress)
                .Include(f => f.DefaultShippingAddress)                
                .Where(c => c.Id >= minLimit && c.Id <= maxLimit).ToListAsync();
        }

        public async Task<StormyCustomer> GetCustomerByIdAsync(long id)
        {
            return await _customerRepository.GetByIdAsync(id);
        }

        public async Task<StormyCustomer> GetCustomerByUserName(string username)
        {
            return await _customerRepository.Table.Where(f => f.UserName == username).FirstAsync();
        }

        public Task<StormyCustomer> GetCustomerByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<StormyCustomer> GetCustomerByUserNameOrEmail(string username, string email)
        {
            return await _customerRepository
            .Table            
            .FirstOrDefaultAsync(
                f => f.UserName.Equals(username) || 
                f.Email.Equals(email));
        }

        public Task EditCustomerReviewAsync(Review review, StormyCustomer customer)
        {
            throw new NotImplementedException();
        }
        //TODO: Change to search based on a SQL query
        public int GetCustomersCount()
        {
            return _customerRepository.Table.Where(c => !c.IsDeleted).ToList().Count();
        }
    }
}
