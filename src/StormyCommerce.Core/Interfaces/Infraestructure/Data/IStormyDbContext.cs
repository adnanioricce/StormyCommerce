using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Infraestructure.Data
{
    public interface IStormyDbContext : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges(bool acceptAllChangesOnSuccess);

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken);
    }
}
