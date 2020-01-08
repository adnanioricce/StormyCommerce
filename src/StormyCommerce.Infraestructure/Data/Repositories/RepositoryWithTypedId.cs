using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;

namespace StormyCommerce.Infraestructure.Data.Repositories
{
    public class RepositoryWithTypedId<T, TId> : IRepositoryWithTypedId<T, TId> where T : class, IEntityBaseWithTypedId<TId>
    {
        public RepositoryWithTypedId(StormyDbContext context)
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

        public async Task<T> GetByIdAsync(params object[] keyValues)
        {
            var entity = await DbSet.FindAsync(keyValues);
            Context.Entry(entity).State = EntityState.Detached;
            return entity;
        }
    }
}
