using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;

namespace SimplCommerce.Tests
{
    public class FakeTransaction : IDbContextTransaction
    {
        public Guid TransactionId => Guid.NewGuid();

        public void Commit()
        {
            return;
        }

        public Task CommitAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(cancellationToken);
        }

        public void Dispose()
        {
            
        }

        public ValueTask DisposeAsync()
        {
            return new ValueTask();
        }

        public void Rollback()
        {
            return;
        }

        public Task RollbackAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(cancellationToken);
        }
    }
}
