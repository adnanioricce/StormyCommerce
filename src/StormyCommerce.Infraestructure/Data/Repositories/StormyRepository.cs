using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;

namespace StormyCommerce.Infraestructure.Data.Repositories
{
    public class StormyRepository<TEntity> : IStormyRepository<TEntity> where TEntity : BaseEntity
    {
        //? I ask myself:what is the difference between this and a readonly field? and Why Protected?
        private readonly StormyDbContext context;
        protected DbSet<TEntity> DbSet => _dbSet ?? (_dbSet = context.Set<TEntity>());
        private DbSet<TEntity> _dbSet;
        public StormyRepository(StormyDbContext _context)
        {
            context = _context;
            _dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> Table => DbSet;
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
            catch(DbUpdateException exception)
            {
                throw new Exception("Failed to perform Insert operation on Database",exception);
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
                throw new Exception("failed to perform Remove operation",exception);
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
                throw new Exception($"Failed to perform Remove operation on Database",exception);
            }
        }

        public async Task<IList<TEntity>> GetAllAsync() => await DbSet.ToListAsync();

        public async Task<TEntity> GetByIdAsync(long id)
        {            
            var entity = await DbSet.FindAsync(id) ??  throw new ArgumentNullException($"Requested entity id Don't exist");
            context.Entry(entity).State = EntityState.Detached;
            return entity;
        }        
        public async Task UpdateAsync(TEntity _entity)
        {
            var entity = _entity ?? throw new ArgumentNullException($"Given argument was null:{_entity.ToString()}");
            try
            {                
                context.Update(entity);                
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException exception)
            {
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
            
            var entities = new List<TEntity>();
            await DbSet.ForEachAsync(f =>
            {
                entities.Add(f);
            });
            return entities;
        }

        public IDbContextTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }
        public static bool IsItNew(StormyDbContext context, TEntity entity) => !context.Entry(entity).IsKeySet;
    }
}
