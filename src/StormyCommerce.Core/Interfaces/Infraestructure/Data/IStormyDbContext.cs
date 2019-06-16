using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Core.Interfaces.Infraestructure.Data
{
    public interface IStormyDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity; 
        int SaveChanges(bool acceptAllChangesOnSuccess); 
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,CancellationToken cancellationToken);
    }
}
