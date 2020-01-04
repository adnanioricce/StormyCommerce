using SimplCommerce.Module.Core.Data;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Reviews.Models;
using StormyCommerce.Core.Entities;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using System.Linq;

namespace SimplCommerce.Module.Reviews.Data
{
    public class ReplyRepository : StormyRepository<Reply>, IReplyRepository
    {
        public ReplyRepository(StormyDbContext context) : base(context)
        {
        }

        public IQueryable<ReplyListItemDto> List()
        {
            var items = from rv in context.Set<Review>()
                         join e in context.Set<Entity>()
                         on new { key1 = rv.Id, key2 = rv.EntityTypeId } equals new { key1 = e.Id, key2 = e.EntityTypeId }
                         join rp in context.Set<Reply>()
                         on rv.Id equals rp.ReviewId
                         select new ReplyListItemDto
                         {
                             Id = rp.Id,
                             ReplierName = rp.ReplierName,
                             Comment = rp.Comment,
                             Status = rp.Status,
                             CreatedOn = rp.CreatedOn,
                             ReviewTitle = rv.Title,
                             EntityName = e.Name,
                             EntitySlug = e.Slug
                         };

            return items;
        }
    }
}
