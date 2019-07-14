using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure;
using SimplCommerce.Infrastructure.Data;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Product;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Mapping.Catalog;

namespace StormyCommerce.Infraestructure.Data
{
    //TODO: Methods to execute sql     
    public class StormyDbContext : IdentityDbContext
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

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,CancellationToken cancellationToken)
        {
            ValidateEntities();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess,cancellationToken);
        }        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {                                          
            var typeConfigurations = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => (type.BaseType?.IsGenericType ?? false) 
                && (type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)));            
            RegisterEntities(modelBuilder, typeConfigurations);
            RegisterConvention(modelBuilder);
            RegisterCustomMappings(modelBuilder,typeConfigurations);            
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
        private static void RegisterConvention(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                if (entity.ClrType.Namespace != null)
                {
                    var nameParts = entity.ClrType.Namespace.Split('.');
                    var tableName = string.Concat(nameParts[2], "_", entity.ClrType.Name);
                    modelBuilder.Entity(entity.Name).ToTable(tableName);
                }
            }

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
        private static void RegisterEntities(ModelBuilder modelBuilder, IEnumerable<Type> typeToRegisters)
        {
            var entityTypes = typeToRegisters.Where(x => x.GetTypeInfo().IsSubclassOf(typeof(BaseEntity)));
            foreach (var type in entityTypes)
            {
                modelBuilder.Entity(type);
            }
        }
        private static void RegisterCustomMappings(ModelBuilder modelBuilder, IEnumerable<Type> typeToRegisters)
        {
            var customModelBuilderTypes = typeToRegisters.Where(x => typeof(IStormyModelBuilder).IsAssignableFrom(x));
            foreach (var builderType in customModelBuilderTypes)
            {
                if (builderType != null && builderType != typeof(IStormyModelBuilder))
                {
                    var builder = (IStormyModelBuilder)Activator.CreateInstance(builderType);
                    builder.Build(modelBuilder);
                }

            }
        }
    }
}
