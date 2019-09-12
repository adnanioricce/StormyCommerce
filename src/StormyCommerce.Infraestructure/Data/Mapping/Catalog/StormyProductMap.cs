using Microsoft.EntityFrameworkCore;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Media;

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
            modelBuilder.Entity<ProductLink>(entity =>
            {
                entity.HasOne(x => x.LinkedProduct)
                .WithMany(p => p.LinkedProductLinks)
                .HasForeignKey(x => x.LinkedProductId)
                .OnDelete(DeleteBehavior.Restrict);
                // entity.HasData(Seeders.ProductLinkSeed(50));
            });
            modelBuilder.Entity<ProductTemplateProductAttribute>(entity =>
            {
                entity.HasKey(t => new { t.ProductTemplateId, t.ProductAttributeId });
            });
            modelBuilder.Entity<ProductTemplateProductAttribute>(entity =>
            {
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
                entity.Property(product => product.BrandId);
                entity.HasOne(product => product.Brand).WithMany().HasForeignKey(p => p.BrandId);
                entity.Property(product => product.VendorId);
                entity.HasOne(product => product.Vendor).WithMany().HasForeignKey(p => p.VendorId);
                entity.Property(product => product.MediaId);
                entity.HasMany(product => product.Medias).WithOne().HasForeignKey(m => m.Id);
                entity.HasMany(product => product.Links).WithOne().HasForeignKey(l => l.Id);
                entity.HasOne(product => product.Category).WithOne();
                entity.Property(product => product.SKU).IsRequired();
                entity.Property(product => product.ProductName).HasMaxLength(400).IsRequired();
                entity.Property(product => product.UnitsOnOrder).IsRequired();
                entity.Property(product => product.QuantityPerUnity).IsRequired();
                entity.Property(product => product.ProductCost).IsRequired();
                entity.Property(product => product.OldPrice);
                entity.Property(product => product.Price);
                entity.Property(product => product.Discount);
                entity.Property(product => product.UnitSize).IsRequired();
                entity.Property(product => product.UnitPrice).IsRequired();
                entity.Property(product => product.UnitsInStock).IsRequired();
                entity.Property(product => product.TypeName).IsRequired();
                entity.Property(product => product.Status).IsRequired();
                entity.Property(product => product.ThumbnailImage);
                //entity.HasData(Seeders.StormyProductSeed(50));
            });

            modelBuilder.Entity<ProductOption>(entity =>
            {
            });
            modelBuilder.Entity<Media>(entity =>
            {
                // entity.HasData();
                //entity.HasData(Seeders.MediaSeed(50));
            });
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasQueryFilter(brand => brand.IsDeleted == false)
                .Property(brand => brand.Slug)
                .HasMaxLength(450)
                .IsRequired();
                //entity.HasData(Seeders.BrandSeed(10));
            });
        }
    }
}
