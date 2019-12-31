using Microsoft.EntityFrameworkCore.Storage;
using StormyCommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces
{
    public interface IStormyRepository<T> where T : class
    {
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);

        Task<IList<T>> GetAllByIdsAsync(long[] ids);

        Task<T> GetByIdAsync(params object[] keyValues);
        Task<T> GetByIdAsync(long id);
        Task UpdateAsync(T entity);
        void Update(T entity);

        Task UpdateCollectionAsync(IEnumerable<T> entities);

        void Delete(T entity);

        void DeleteCollection(IEnumerable<T> entities);

        Task AddAsync(T entity);
        void Add(T entity);

        Task AddCollectionAsync(IEnumerable<T> entities);

        Task SaveChangesAsync();

        void SaveChanges();

        IQueryable<T> Query();

        IDbContextTransaction BeginTransaction();
    }
}
