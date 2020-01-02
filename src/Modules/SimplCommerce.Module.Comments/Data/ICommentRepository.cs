using System.Linq;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Comments.Models;
using StormyCommerce.Core.Interfaces;

namespace SimplCommerce.Module.Comments.Data
{
    public interface ICommentRepository : IStormyRepository<Comment>
    {
        IQueryable<CommentListItemDto> List();
    }
}
