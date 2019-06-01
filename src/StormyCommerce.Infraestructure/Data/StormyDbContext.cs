﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Infrastructure.Models;

namespace StormyCommerce.Infraestructure.Data
{
    //TODO: Methods to execute sql     
    public class StormyDbContext : DbContext
    {
        public StormyDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            ValidateEntities();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,CancellationToken cancellationToken = default(CancellationToken))
        {
            ValidateEntities();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess,cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Type> typeToRegisters = new List<Type>();
            foreach(var module in GlobalConfiguration.Modules)
            {
                typeToRegisters.AddRange(module.Assembly.DefinedTypes.Select(t => t.AsType()));
            }
            RegisterEntities(modelBuilder,typeToRegisters);
            RegisterConvention(modelBuilder);
            base.OnModelCreating(modelBuilder);
            RegisterCustomMappings(modelBuilder,typeToRegisters);
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
            var entityTypes = typeToRegisters.Where(x => x.GetTypeInfo().IsSubclassOf(typeof(EntityBase)) && !x.GetTypeInfo().IsAbstract);
            foreach (var type in entityTypes)
            {
                modelBuilder.Entity(type);
            }
        }
        private static void RegisterCustomMappings(ModelBuilder modelBuilder, IEnumerable<Type> typeToRegisters)
        {
            var customModelBuilderTypes = typeToRegisters.Where(x => typeof(ICustomModelBuilder).IsAssignableFrom(x));
            foreach (var builderType in customModelBuilderTypes)
            {
                if (builderType != null && builderType != typeof(ICustomModelBuilder))
                {
                    var builder = (ICustomModelBuilder)Activator.CreateInstance(builderType);
                    builder.Build(modelBuilder);
                }
            }
        }
    }
}