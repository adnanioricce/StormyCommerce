using SimplCommerce.Module.Core.Data;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Reviews.Models;
using StormyCommerce.Core.Entities;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using System.Linq;

namespace SimplCommerce.Module.Reviews.Data
{
    public class ReviewRepository : StormyRepository<Review>,IReviewRepository
    {
        //TODO:change the dbcontext to the SimplDbContext
        public ReviewRepository(StormyDbContext context) : base(context)
        {
        }

        public IQueryable<ReviewListItemDto> List()
        {
            var items = DbSet.Join(context.Set<Entity>(),
                r => new { key1 = r.EntityId, key2 = r.EntityTypeId },
                u => new { key1 = u.Id, key2 = u.EntityTypeId },
                (r, u) => new ReviewListItemDto
                {
                    EntityTypeId = r.EntityTypeId,
                    Id = r.Id,
                    ReviewerName = r.ReviewerName,
                    Rating = r.Rating,
                    Title = r.Title,
                    Comment = r.Comment,
                    Status = r.Status,
                    CreatedOn = r.CreatedOn,
                    EntityName = u.Name,
                    EntitySlug = u.Slug
                });

            return items;
        }
    }
}
