using System.Collections.Generic;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Core.Interfaces.Domain.Customer
{
    public interface IReviewService
    {
        Task<Review> GetCustomerReviewByIdAsync(long id);
        Task<List<Review>> GetCustomerReviews(string customerId);
        Task CreateReviewAsync(Review review);        
        Task EditReviewAsync(Review review);
        Task DeleteReviewAsync(long reviewId);
                
    }
}
