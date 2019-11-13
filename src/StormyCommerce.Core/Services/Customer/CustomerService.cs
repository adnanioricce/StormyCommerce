//using Microsoft.EntityFrameworkCore;
//using StormyCommerce.Core.Entities;
//using StormyCommerce.Core.Entities.Customer;
//using StormyCommerce.Core.Interfaces;
//using StormyCommerce.Core.Interfaces.Domain.Customer;
//using StormyCommerce.Core.Models.Dtos;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace StormyCommerce.Core.Services.Customer
//{
//    public class CustomerService : ICustomerService
//    {
//        private readonly IStormyRepository<Review> _reviewRepository;
//        private readonly IStormyRepository<Wishlist> _wishListRepository;        

//        public CustomerService(IStormyRepository<Review> reviewRepository,
//        IStormyRepository<StormyCustomer> customerRepository,
//        IStormyRepository<Wishlist> wishListRepository)
//        {
//            _reviewRepository = reviewRepository;
//            _customerRepository = customerRepository;
//            _wishListRepository = wishListRepository;
//        }                                
        
//        #region Create Methods
//        public async Task CreateCustomerReviewAsync(Review review, string normalizedEmail)
//        {
//            var customer = await _customerRepository.Table.FirstOrDefaultAsync(f => f.Email.Equals(normalizedEmail));
//            review.Author = customer;
//            if (review == null) throw new ArgumentNullException("given review entity is null");
//            if (customer == null) throw new ArgumentNullException("given customer is null");            
//            customer.CustomerReviews.Add(review);
//            await _customerRepository.UpdateAsync(customer);
//        }                        
//        public async Task AddCustomerAddressAsync(CustomerAddress address, string customerId)
//        {
//            var customer = await _customerRepository.GetByIdAsync(customerId);
//            customer.Addresses.Add(address);
//            await _customerRepository.UpdateAsync(customer);
//        }
//        #endregion
//        #region Update Methods                
//        public async Task EditCustomerReviewAsync(Review review, long customerId)
//        {            
//            var oldReview = await _reviewRepository.GetByIdAsync(review.Id) ?? throw new ArgumentNullException();
//            oldReview.Comment = review.Comment;
//            oldReview.RatingLevel = review.RatingLevel;
//            oldReview.Status = review.Status;
//            oldReview.Title = review.Title;
//            oldReview.ReviewerName = review.ReviewerName;
//            oldReview.IsDeleted = review.IsDeleted;
                        
//            await _reviewRepository.UpdateAsync(oldReview);
//        }
//        public Task EditCustomerReviewAsync(Review review, StormyCustomer customer)
//        {
//            throw new NotImplementedException();
//        }          
//        public async Task DeleteCustomerReviewByIdAsync(long reviewId, long customerId)
//        {            
//            var review = await _reviewRepository.GetByIdAsync(reviewId);
//            review.IsDeleted = true;
//            await _reviewRepository.UpdateAsync(review);            
//        }
//        #endregion
//        #region Read Operations                

//        public async Task AddWishListItem(StormyCustomer customer,long productId)
//        {
//            var wishList = await _wishListRepository.GetByIdAsync(customer.CustomerWishlistId);
//            wishList.WishlistItems.Add(new WishlistItem
//            {
//                Id = 0,
//                Wishlist = wishList,
//                ProductId = productId
//            });
//            await _wishListRepository.UpdateAsync(wishList);
//        }
//        #endregion
//    }
//}
