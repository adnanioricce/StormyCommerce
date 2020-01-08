
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Core.Interfaces.Infraestructure.Data
{
    public interface IRepositoryWithTypedId<T, TId> where T : IEntityBaseWithTypedId<TId>
    {
        IQueryable<T> Query();
        Task<T> GetByIdAsync(params object[] keyValues);
        void Add(T entity);

        void AddRange(IEnumerable<T> entity);

        IDbContextTransaction BeginTransaction();

        void SaveChanges();

        Task SaveChangesAsync();

        void Remove(T entity);
    }
}
