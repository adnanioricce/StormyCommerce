using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Module.Core.Data
{
    public class RepositoryWithTypedId<T, TId> : IRepositoryWithTypedId<T, TId> where T : class,IEntityWithTypedId<TId> where TId : IEquatable<TId>
    {
        public RepositoryWithTypedId(SimplDbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        protected DbContext Context { get; }

        protected DbSet<T> DbSet { get; }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entity)
        {
            DbSet.AddRange(entity);
        }

        public IDbContextTransaction BeginTransaction()
        {
            return Context.Database.BeginTransaction();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }

        public IQueryable<T> Query()
        {
            return DbSet;
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        public async Task<T> GetByIdAsync(TId id) 
        {                        
            var entity = await DbSet.FindAsync(id);
            Context.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public async Task<T> GetByIdAsync(params object[] keyValues)
        {            
            var entity = await DbSet.FindAsync(keyValues);
            Context.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public async Task<IList<T>> GetAllByIdsAsync(IEnumerable<TId> ids) 
        {            
            if (ids == null) throw new ArgumentNullException("Given argument is null");                    
            return await DbSet.Where(p => ids.Any(d => d.Equals(p.Id))).ToListAsync();
        }

        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            var query = predicate != null ? Query().Where(predicate) : Query();            
            return await query.ToListAsync();
        }

        public void Update(T _entity)
        {
            DbSet.Update(_entity);
        }

        public async Task UpdateAsync(T _entity)
        {
            var entity = _entity ?? throw new ArgumentNullException($"Given argument was null:{_entity.ToString()}");
            try
            {
                var entry = DbSet.FirstOrDefault(e =>  object.Equals(e.Id, entity.Id));
                Context.Entry(entry).CurrentValues.SetValues(entity);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateException exception)
            {                
                throw new Exception($"Failed to perform update operation against the database", exception);
            }
        }

        public async Task UpdateCollectionAsync(IEnumerable<T> _entities)
        {
            var entities = _entities ?? throw new NullReferenceException($"Given argument was null");
            try
            {                
                DbSet.UpdateRange(entities);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateException exception)
            {
                throw new Exception("Failed to perform update operation against the database", exception);
            }
        }

        public async Task AddAsync(T _entity)
        {
            var entity = _entity ?? throw new ArgumentNullException($"Given argument was null:{_entity.ToString()}");

            try
            {
                DbSet.Add(entity);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateException exception)
            {
                await Task.FromException(exception);
            }
        }

        public async Task AddCollectionAsync(IEnumerable<T> _entities)
        {
            var entities = _entities ?? throw new ArgumentNullException($"Given argument was null:{_entities.ToString()}");
            try
            {
                DbSet.AddRange(entities);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateException exception)
            {
                throw new Exception("Failed to perform Insert operation on Database", exception);
            }
        }

        public void RemoveCollection(IEnumerable<T> _entities)
        {
            var entities = _entities ?? throw new ArgumentNullException($"Given argument was null:{_entities.ToString()}");
            try
            {
                DbSet.RemoveRange(entities);
                Context.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                throw new Exception($"Failed to perform Remove operation on Database", exception);
            }
        }
        public static bool IsItNew(SimplDbContext context, T entity) => !context.Entry(entity).IsKeySet;
    }
}
