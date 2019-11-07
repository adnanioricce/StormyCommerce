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
        public async Task CreateReviewCustomerAsync(Review review)
        {
            await _reviewRepository.AddAsync(review);
        }

        public async Task<Review> GetCustomerReviewByIdAsync(long id)
        {
            return await _reviewRepository.Table                
                .Include(r => r.Author)
                .Where(r => r.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Review>> GetCustomerReviews(string customerId)
        {
            return await _reviewRepository.Table
                .Include(r => r.Author)
                .Where(r => r.StormyCustomerId == customerId)
                .ToListAsync();
        }
    }
}
