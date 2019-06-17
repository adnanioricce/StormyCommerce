using System.Threading;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Uow
{
    public interface IUnitOfWork
    {
        bool Commit(bool acceptAllChangeOnSuccess);
        Task<bool> CommitAsync(bool acceptAllChangeOnSuccess,CancellationToken cancellationToken);
    }
}
