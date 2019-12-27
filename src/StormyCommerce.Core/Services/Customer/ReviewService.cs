using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Customer;

namespace StormyCommerce.Core.Services.Customer
{
    //TODO: Delete Operations
    //TODO: Update Operations
    public class ReviewService : IReviewService
    {
        private readonly IStormyRepository<Review> _reviewRepository;
        public ReviewService(IStormyRepository<Review> reviewRepository)
        {
            _reviewRepository = reviewRepository;            
        }
        public async Task CreateReviewAsync(Review review)
        {
            await _reviewRepository.AddAsync(review);
        }
        public async Task EditReviewAsync(Review review)
        {
            await _reviewRepository.UpdateAsync(review);
        }
        public async Task DeleteReviewAsync(long reviewId)
        {
            var review = await _reviewRepository.GetByIdAsync(reviewId);
            review.IsDeleted = true;
            await _reviewRepository.UpdateAsync(review);
        }
        public async Task<Review> GetCustomerReviewByIdAsync(long id)
        {
            return await _reviewRepository.Query()                
                .Include(r => r.Author)
                .Where(r => r.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Review>> GetCustomerReviews(long customerId)
        {
            return await _reviewRepository.Query()
                .Include(r => r.Author)
                .Where(r => r.UserId == customerId)
                .ToListAsync();
        }
    }
}
