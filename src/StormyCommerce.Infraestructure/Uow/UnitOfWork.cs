using System.Threading;
using System.Threading.Tasks;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Core.Uow;

namespace StormyCommerce.Infraestructure.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IStormyDbContext _dbContext;
        public UnitOfWork(IStormyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool Commit(bool acceptAllChangeOnSuccess)
        {
            return _dbContext.SaveChanges(acceptAllChangeOnSuccess) > 0;
        }

        public async Task<bool> CommitAsync(bool acceptAllChangeOnSuccess, CancellationToken cancellationToken)
        {
            return await _dbContext.SaveChangesAsync(acceptAllChangeOnSuccess,cancellationToken) > 0;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
