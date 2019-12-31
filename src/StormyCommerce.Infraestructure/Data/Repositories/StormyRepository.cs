using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StormyCommerce.Infraestructure.Data.Repositories
{
    public class StormyRepository<TEntity> : IStormyRepository<TEntity> where TEntity : EntityBaseWithTypedId<long>
    {        
        protected readonly StormyDbContext context;

        protected DbSet<TEntity> DbSet => _dbSet ?? (_dbSet = context.Set<TEntity>());
        private DbSet<TEntity> _dbSet;

        public StormyRepository(StormyDbContext _context)
        {
            context = _context;
            _dbSet = context.Set<TEntity>();            
        }
        public IQueryable<TEntity> Query() 
        {
            return DbSet.Include(context.GetIncludePaths(typeof(TEntity)));            
        }

        public async Task AddAsync(TEntity _entity)
        {
            var entity = _entity ?? throw new ArgumentNullException($"Given argument was null:{_entity.ToString()}");

            try
            {
                DbSet.Add(entity);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException exception)
            {
                await Task.FromException(exception);
            }
        }

        public async Task AddCollectionAsync(IEnumerable<TEntity> _entities)
        {
            var entities = _entities ?? throw new ArgumentNullException($"Given argument was null:{_entities.ToString()}");
            try
            {
                DbSet.AddRange(entities);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException exception)
            {
                throw new Exception("Failed to perform Insert operation on Database", exception);
            }
        }

        public void Delete(TEntity _entity)
        {
            var entity = _entity ?? throw new ArgumentNullException($"Given argument was null:{_entity.ToString()}");
            try
            {
                DbSet.Remove(entity);
                context.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                throw new Exception("failed to perform Remove operation", exception);
            }
        }

        public void DeleteCollection(IEnumerable<TEntity> _entities)
        {
            var entities = _entities ?? throw new ArgumentNullException($"Given argument was null:{_entities.ToString()}");
            try
            {
                DbSet.RemoveRange(entities);
                context.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                throw new Exception($"Failed to perform Remove operation on Database", exception);
            }
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity,bool>> predicate = null)
        {         
            var query = predicate != null ? Query().Where(predicate) : Query();            
            return await query.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(params object[] keyValues)
        {
            var entity = await DbSet.FindAsync(keyValues);
            context.Entry(entity).State = EntityState.Detached;
            return entity;
        }
        public async Task<TEntity> GetByIdAsync(long id)
        {
            var entity = await DbSet.FindAsync(id);
            context.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public async Task UpdateAsync(TEntity _entity)
        {
            var entity = _entity ?? throw new ArgumentNullException($"Given argument was null:{_entity.ToString()}");
            try
            {
                var entry = _dbSet.First(e => e.Id == entity.Id);
                context.Entry(entry).CurrentValues.SetValues(entity);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException exception)
            {
                // var entity =
                throw new Exception($"Failed to perform update operation against the database", exception);
            }
        }

        public async Task UpdateCollectionAsync(IEnumerable<TEntity> _entities)
        {
            var entities = _entities ?? throw new NullReferenceException($"Given argument was null");
            try
            {
                //TODO:How to refactor this?
                DbSet.UpdateRange(entities);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException exception)
            {
                throw new Exception("Failed to perform update operation against the database", exception);
            }
        }

        public async Task<IList<TEntity>> GetAllByIdsAsync(long[] ids)
        {
            if (ids == null) throw new ArgumentNullException("Given argument is null");                    
            return await _dbSet.Where(p => ids.Contains(p.Id)).ToListAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public static bool IsItNew(StormyDbContext context, TEntity entity) => !context.Entry(entity).IsKeySet;

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }
    }
}
