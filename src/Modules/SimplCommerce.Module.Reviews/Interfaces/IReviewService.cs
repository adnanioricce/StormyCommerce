using System.Collections.Generic;
using System.Threading.Tasks;
using SimplCommerce.Module.Reviews.Models;
using StormyCommerce.Core.Entities;

namespace SimplCommerce.Module.Reviews.Interfaces
{
    public interface IReviewService
    {
        Task<Review> GetCustomerReviewByIdAsync(long id);
        Task<List<Review>> GetCustomerReviews(long customerId);
        Task CreateReviewAsync(Review review);        
        Task EditReviewAsync(Review review);
        Task DeleteReviewAsync(long reviewId);
                
    }
}
