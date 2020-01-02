using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Reviews.Models;
using StormyCommerce.Core.Interfaces;
using System.Linq;

namespace SimplCommerce.Module.Reviews.Data
{
    public interface IReviewRepository : IStormyRepository<Review>
    {
        IQueryable<ReviewListItemDto> List();
    }
}
