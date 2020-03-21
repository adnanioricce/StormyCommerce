using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Tests
{
    public class FakeRepositoryWithTypedId<T, TId> : IRepositoryWithTypedId<T, TId> where T : class, IEntityWithTypedId<TId> where TId : IEquatable<TId>
    {
        private readonly List<T> _dataSource = new List<T>();
        public FakeRepositoryWithTypedId()
        {

        }
        public FakeRepositoryWithTypedId(List<T> data)
        {
            _dataSource = data;
        }
        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("given entity is null");
            }
            if (!_dataSource.Exists(i => object.Equals(i.Id,entity.Id)))
            {
                _dataSource.Add(entity);
                return;
            }
            throw new InvalidOperationException("the data source already have the given entity");
        }

        public Task AddAsync(T entity)
        {
            return Task.Run(() => Add(entity));
        }

        public Task AddCollectionAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<T> entity)
        {
            foreach (var item in entity)
            {
                Add(item);
            }

        }

        public IDbContextTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return Task.Run<IList<T>>(() => _dataSource.Where(predicate.Compile())
                           .ToList());
            }
            return Task.Run<IList<T>>(() => _dataSource.ToList());
            //return 
        }

        public Task<IList<T>> GetAllByIdsAsync(IEnumerable<long> ids)
        {
            return Task.Run<IList<T>>(() => _dataSource.Where(k => ids.Any(id => object.Equals(id ,k.Id)))
                                                       .ToList());
        }

        public Task<IList<T>> GetAllByIdsAsync(IEnumerable<TId> ids)
        {
            throw new NotImplementedException();
        }

        public T GetById(TId id)
        {
            return _dataSource.Find(i => object.Equals(i.Id,id));
        }

        public Task<T> GetByIdAsync(long id)
        {
            return Task.Run<T>(() => _dataSource.Find(e => object.Equals(e.Id,id)));
        }

        public Task<T> GetByIdAsync(params object[] keyValues)
        {
            //OBS:this probably don't work
            return Task.Run<T>(() => _dataSource.Find(e => keyValues.Any(key => object.Equals(key, e.Id))));
        }

        public Task<T> GetByIdAsync(TId id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query()
        {
            return _dataSource.AsQueryable();
        }

        public void Remove(T entity)
        {
            if (!(_dataSource.Exists(e => object.Equals(e.Id,entity.Id)))) throw new InvalidOperationException("its not possible to remove entity because it not exist");
            _dataSource.Remove(entity);

        }

        public void RemoveCollection(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                _dataSource.Remove(entity);
            }
        }

        public void SaveChanges()
        {
            return;
        }

        public Task SaveChangesAsync()
        {
            return Task.Delay(0);
        }

        public void Update(T entity)
        {
            int index = _dataSource.FindIndex(0, p => object.Equals(p.Id,entity.Id));
            _dataSource[index] = entity;
        }

        public Task UpdateAsync(T entity)
        {
            return Task.Run(() => Update(entity));
        }

        public Task UpdateCollectionAsync(IEnumerable<T> entities)
        {
            return Task.Run(() =>
            {
                foreach (var entity in entities)
                {
                    Update(entity);
                }
            });
        }
    }
}
