using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
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
        
        #region Create Methods
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
        public async Task AddCustomerAddressAsync(CustomerAddress address, long customerId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);
            customer.Addresses.Add(address);
            await _customerRepository.UpdateAsync(customer);
        }
        #endregion
        #region Update Methods
        public async Task EditCustomerAsync(CustomerDto customer)
        {
            await _customerRepository.UpdateAsync(new StormyCustomer(customer));
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
        public Task EditCustomerReviewAsync(Review review, StormyCustomer customer)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteCustomerByIdAsync(long id)
        {            
            var customer = await _customerRepository.GetByIdAsync(id);
            customer.IsDeleted = true;            
            await _customerRepository.UpdateAsync(customer);
        }            
        public async Task DeleteCustomerReviewByIdAsync(long reviewId, long customerId)
        {            
            var review = await _reviewRepository.GetByIdAsync(reviewId);
            review.IsDeleted = true;
            await _reviewRepository.UpdateAsync(review);            
        }
        #endregion
        #region Read Operations
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
            return _customerRepository.Table.Where(f => f.Email == email).FirstAsync();
        }
        public async Task<StormyCustomer> GetCustomerByUserNameOrEmail(string username, string email)
        {
            return await _customerRepository
            .Table            
            .FirstOrDefaultAsync(
                f => f.UserName.Equals(username) || 
                f.Email.Equals(email));
        }
        public int GetCustomersCount()
        {
            return _customerRepository.Table.Where(c => !c.IsDeleted).ToList().Count();
        }        
        public async Task<IList<CustomerAddress>> GetAllCustomerAddressByIdAsync(long id)
        {
            return (await _customerRepository.Table.Include(a => a.Addresses).FirstOrDefaultAsync(c => c.Id == id)).Addresses;
        }                
        #endregion                        
    }
}
