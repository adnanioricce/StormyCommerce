using Microsoft.EntityFrameworkCore.Storage;
using StormyCommerce.Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces
{
    public interface IStormyRepository<T> where T : BaseEntity
    {
        Task<IList<T>> GetAllAsync();

        Task<IList<T>> GetAllByIdsAsync(long[] ids);

        Task<T> GetByIdAsync(params object[] keyValues);
        Task<T> GetByIdAsync(long id);
        Task UpdateAsync(T entity);

        Task UpdateCollectionAsync(IEnumerable<T> entities);

        void Delete(T entity);

        void DeleteCollection(IEnumerable<T> entities);

        Task AddAsync(T entity);

        Task AddCollectionAsync(IEnumerable<T> entities);

        Task SaveChangesAsync();

        void SaveChanges();

        IQueryable<T> Table { get; }

        IDbContextTransaction BeginTransaction();
    }
}
