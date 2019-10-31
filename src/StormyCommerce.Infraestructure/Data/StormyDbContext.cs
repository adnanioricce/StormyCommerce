using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace StormyCommerce.Infraestructure.Data
{
    //TODO: Methods to execute sql
    public class StormyDbContext : IdentityDbContext,IStormyDbContext
    {        
        public StormyDbContext(DbContextOptions<StormyDbContext> options) : base(options)
        {
            
        }

        public virtual new DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            ValidateEntities();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken)
        {
            ValidateEntities();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ForNpgsqlUseIdentityColumns();
            Type baseType = typeof(IStormyModelBuilder);
            var typeConfigurations = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type => baseType.IsAssignableFrom(type) && !type.IsInterface);            
            RegisterCustomMappings(modelBuilder, typeConfigurations);
            base.OnModelCreating(modelBuilder);
        }                 
        //TODO:Move this to a helper class
        private void ValidateEntities()
        {
            var modifiedEntries = ChangeTracker.Entries()
                    .Where(x => (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in modifiedEntries)
            {
                if (entity.Entity is ValidatableObject validatableObject)
                {
                    var validationResults = validatableObject.Validate();
                    if (validationResults.Any())
                    {
                        throw new ValidationException(entity.Entity.GetType(), validationResults);
                    }
                }
            }
        }
        private static void RegisterCustomMappings(ModelBuilder modelBuilder, IEnumerable<Type> typeToRegisters)
        {
            var customModelBuilderTypes = typeToRegisters.Where(x => typeof(IStormyModelBuilder).IsAssignableFrom(x));
            //var customModelBuilderTypes = typeToRegisters;
            foreach (var builderType in customModelBuilderTypes)
            {
                var builder = (IStormyModelBuilder)Activator.CreateInstance(builderType);
                builder.Build(modelBuilder);
            }
        }
    }
}
