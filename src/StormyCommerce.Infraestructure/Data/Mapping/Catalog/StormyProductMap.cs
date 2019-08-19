﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplCommerce.Infrastructure.Data;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Entities.Vendor;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    //!I Decided not use Widgets for now, maybe I change my mind
    public class StormyProductMap : IStormyModelBuilder
    {
        
        public void Build(ModelBuilder modelBuilder)
        {
            //modelBuilder.Model.GetEntityTypes().ToList().ForEach(entity =>
            //{
            //    entity.GetOrAddProperty("IsDeleted", typeof(bool));
            //    var parameter = Expression.Parameter(entity.ClrType);
            //    var propertyMethodInfo = typeof(EF).GetMethod("Property").MakeGenericMethod(typeof(bool));
            //    var isDeletedProperty = Expression.Call(propertyMethodInfo, parameter, Expression.Constant("IsDeleted"));
            //    BinaryExpression compareExpression = Expression.MakeBinary(ExpressionType.Equal, isDeletedProperty, Expression.Constant(false));
            //    var lambda = Expression.Lambda(compareExpression, parameter);
            //    modelBuilder.Entity(entity.ClrType).HasQueryFilter(lambda);
            //});            
            modelBuilder.Entity<ProductLink>(entity =>
            {
                entity.HasOne(x => x.Product)
                .WithMany(p => p.Links)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<ProductLink>(entity =>
            {
                entity.HasOne(x => x.Product)
                .WithMany(p => p.Links)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<ProductLink>(entity => {
                entity.HasOne(x => x.LinkedProduct)
                .WithMany(p => p.LinkedProductLinks)
                .HasForeignKey(x => x.LinkedProductId)
                .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<ProductTemplateProductAttribute>(entity => 
            {
                entity.HasKey(t => new { t.ProductTemplateId, t.ProductAttributeId });
            });
            modelBuilder.Entity<ProductTemplateProductAttribute>(entity => {
                entity.HasOne(pt => pt.ProductTemplate)
                .WithMany(p => p.ProductAttributes)
                .HasForeignKey(pt => pt.ProductTemplateId)
                .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<ProductTemplateProductAttribute>(entity =>
            {
                entity.HasOne(pt => pt.ProductAttribute)
                .WithMany(t => t.ProductTemplates)
                .HasForeignKey(pt => pt.ProductAttributeId)
                .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<StormyProduct>(entity =>
            {
                entity.HasQueryFilter(product => !product.IsDeleted);
                entity.Property(p => p.Price);
                entity.Property(p => p.OldPrice);
                //entity.HasData(new StormyProduct(1)
                //{
                //    SKU = "33E353EE-40A9-4AAA-9FA4-E0A196DC10ED",
                //    AllowCustomerReview = true,
                //    ApprovedRatingSum = 5,
                //    ApprovedTotalReviews = 32,
                //    AvailableForPreorder = false,
                //    BrandId = 1,
                //    CreatedAt = new DateTime(2019, 05, 10),
                //    IsDeleted = false,
                //    Discount = (decimal)9.99,
                //    DiscountAvailable = false,
                //    HasDiscountApplied = false,
                //    PreOrderAvailabilityStartDate = null,
                //    ProductAvailable = true,
                //    NotApprovedRatingSum = 2,
                //    NotApprovedTotalReviews = 10,
                //    VendorId = 1,
                //    UnitPrice = (decimal)49.99,
                //    UnitsInStock = 30,
                //});                
            });
            
            modelBuilder.Entity<ProductOption>(entity =>
            {
                entity.HasData(new ProductOption(1) { Name = "Color" },
                new ProductOption(2) { Name = "Size" });                
            });
            modelBuilder.Entity<Media>(entity => 
            {
                entity.HasKey(prop => prop.Id);                
            });
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasQueryFilter(brand => brand.IsDeleted == false)
                .Property(brand => brand.Slug)
                .HasMaxLength(450)
                .IsRequired();
                entity.HasData(new Brand(2)
                {
                    IsDeleted = false,
                    Description = "description",
                    LastModified = new DateTime(2019, 03, 02),
                    LogoImage = "no Image",
                    Name = "A brand",
                    Slug = "my-awesome-brand"
                });                
            });

            //modelBuilder.Entity<StormyProduct>().OwnsOne(f => f.Medias) ;
            //Configure(modelBuilder.Entity<StormyProduct>());
            
        }
        //public override void Configure(EntityTypeBuilder<StormyProduct> builder)
        //{
        //    builder.HasOne(product => product.Brand).WithMany().HasForeignKey(p => p.BrandId);
        //    builder.Property(product => product.BrandId);
        //    builder.Property(product => product.VendorId);
        //    builder.HasOne(product => product.Vendor).WithMany().HasForeignKey(p => p.VendorId);
        //    builder.Property(product => product.MediaId);
        //    builder.HasOne(product => product.Medias).WithMany().HasForeignKey(p => p.MediaId);
        //    builder.Property(product => product.SKU).IsRequired();
        //    builder.Property(product => product.ProductName).HasMaxLength(400).IsRequired();            
        //    builder.Property(product => product.UnitsOnOrder).IsRequired();
        //    builder.Property(product => product.QuantityPerUnity).IsRequired();
        //    builder.Property(product => product.ProductCost).HasColumnType("decimal(18,4)").IsRequired();
        //    builder.Property(product => product.OldPrice).HasColumnType("decimal(18,4)");
        //    builder.Property(product => product.Price).HasColumnType("decimal(18,4)"); ;
        //    builder.Property(product => product.Discount).HasColumnType("decimal(18,4)"); ;                  
        //    builder.Property(product => product.UnitSize).IsRequired();           
        //    builder.Property(product => product.UnitPrice).HasColumnType("decimal(18,4)").IsRequired();
        //    builder.Property(product => product.UnitsInStock).IsRequired();
        //    builder.Property(product => product.TypeName).IsRequired();
        //    builder.Property(product => product.Status).IsRequired();            
        //    base.Configure(builder);
        //}             
    }
}