using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Infrastructure.Data
{
    public interface IRepositoryWithTypedId<T, TId> where T : IEntityWithTypedId<TId> where TId : IEquatable<TId>
    {
        Task<T> GetByIdAsync(TId id);

        Task<T> GetByIdAsync(params object[] keyValues);

        Task<IList<T>> GetAllByIdsAsync(IEnumerable<TId> ids);

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);                
                
        void Update(T entity);

        Task UpdateAsync(T entity);

        Task UpdateCollectionAsync(IEnumerable<T> entities);
                
        IQueryable<T> Query();

        void Add(T entity);

        Task AddAsync(T entity);        

        Task AddCollectionAsync(IEnumerable<T> entities);              

        void AddRange(IEnumerable<T> entity);

        IDbContextTransaction BeginTransaction();

        void SaveChanges();

        Task SaveChangesAsync();

        void Remove(T entity);        

        void RemoveCollection(IEnumerable<T> entities);    
    }
}
