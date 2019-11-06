using System.Collections.Generic;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Core.Interfaces.Domain.Customer
{
    public interface IReviewService
    {
        Task CreateReviewCustomerAsync(Review review);
        Task<List<Review>> GetCustomerReviews(string customerId);
        Task<Review> GetCustomerReviewByIdAsync(long id);
    }
}
