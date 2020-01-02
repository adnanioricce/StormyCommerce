using System.Linq;
using SimplCommerce.Module.Core.Data;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Comments.Models;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Core.Entities;

namespace SimplCommerce.Module.Comments.Data
{
    public class CommentRepository : StormyRepository<Comment>, ICommentRepository
    {
        public CommentRepository(StormyDbContext context) : base(context)
        {
        }

        public IQueryable<CommentListItemDto> List()
        {
            var items = DbSet.Join(context.Set<Entity>(),
                r => new { key1 = r.EntityId, key2 = r.EntityTypeId },
                u => new { key1 = u.Id, key2 = u.EntityTypeId },
                (r, u) => new CommentListItemDto
                {
                    EntityTypeId = r.EntityTypeId,
                    Id = r.Id,
                    CommenterName = r.CommenterName,
                    CommentText = r.CommentText,
                    Status = r.Status,
                    CreatedOn = r.CreatedOn,
                    ParentId = r.ParentId,
                    EntityName = u.Name,
                    EntitySlug = u.Slug
                });

            return items;
        }
    }
}
