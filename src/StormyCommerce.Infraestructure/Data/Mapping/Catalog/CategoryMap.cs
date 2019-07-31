﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StormyCommerce.Core.Entities.Catalog;

namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    public class CategoryMap : IStormyModelBuilder
    {        
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(builder =>
            {
                builder.HasQueryFilter(category => category.IsDeleted == false);
                builder.HasKey(category => category.Id);                                
                builder.Property(category => category.Name).HasMaxLength(450).IsRequired();
                builder.Property(category => category.Slug).HasMaxLength(450).IsRequired();
                builder.Property(category => category.MetaTitle).HasMaxLength(450);
                builder.Property(category => category.MetaKeywords).HasMaxLength(450);
                builder.Property(category => category.Description).HasMaxLength(450).IsRequired();
            });
                
            //Configure(modelBuilder.Entity<Category>());
        }        
        //public override void Configure(EntityTypeBuilder<Category> builder)
        //{           
        //    builder.HasKey(category => category.Id);
        //    builder.Property(category => category.Name).HasMaxLength(450).IsRequired();
        //    builder.Property(category => category.Slug).HasMaxLength(450).IsRequired();
        //    builder.Property(category => category.MetaTitle).HasMaxLength(450);
        //    builder.Property(category => category.MetaKeywords).HasMaxLength(450);                        
        //    builder.Property(category => category.Description).HasMaxLength(450).IsRequired();            
        //    base.Configure(builder);
        //}
    }
}
