using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplCommerce.Infrastructure.Data;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Media;
using System.Linq;
using System.Linq.Expressions;

namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    //!I Decided not use Widgets for now, maybe I change my mind
    public class ProductMap : EntityTypeConfiguration<StormyProduct>,IStormyModelBuilder
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
            modelBuilder.Entity<ProductMedia>()
                .HasKey(productMedia => productMedia.Id)
                .HasName("product_media_Id");
            modelBuilder.Entity<ProductLink>()
                .HasOne(x => x.Product)
                .WithMany(p => p.Links)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ProductLink>()
                .HasOne(x => x.LinkedProduct)
                .WithMany(p => p.LinkedProductLinks)
                .HasForeignKey(x => x.LinkedProductId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ProductTemplateProductAttribute>()
                .HasKey(t => new { t.ProductTemplateId, t.ProductAttributeId });
            modelBuilder.Entity<ProductTemplateProductAttribute>()
                .HasOne(pt => pt.ProductTemplate)
                .WithMany(p => p.ProductAttributes)
                .HasForeignKey(pt => pt.ProductTemplateId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ProductTemplateProductAttribute>()
                .HasOne(pt => pt.ProductAttribute)
                .WithMany(t => t.ProductTemplates)
                .HasForeignKey(pt => pt.ProductAttributeId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<StormyProduct>().HasQueryFilter(product => product.IsDeleted == false);
            modelBuilder.Entity<EntityType>().HasData(
                new EntityType("Category") { IsDeleted = false, AreaName = "Catalog", RoutingController = "Category", RoutingAction = "CategoryDetail", IsMenuable = true },
                new EntityType("Brand") { IsDeleted = false, AreaName = "Catalog", RoutingController = "Brand", RoutingAction = "BrandDetail", IsMenuable = true },
                new EntityType("Product") { IsDeleted = false, AreaName = "Catalog", RoutingController = "Product", RoutingAction = "ProductDetail", IsMenuable = false }
            );
            modelBuilder.Entity<ProductOption>().HasData(
                new ProductOption(1) { Name = "Color" },
                new ProductOption(2) { Name = "Size" }
            );
            modelBuilder.Entity<Media>().HasKey(media => media.Id);            
            modelBuilder.Entity<Brand>().HasQueryFilter(brand => brand.IsDeleted == false).Property(brand => brand.Slug).HasMaxLength(450).IsRequired();
            //modelBuilder.Entity<StormyProduct>().OwnsOne(f => f.Medias) ;
            //Configure(modelBuilder.Entity<StormyProduct>());
            
        }
        public override void Configure(EntityTypeBuilder<StormyProduct> builder)
        {
            builder.HasOne(product => product.Brand).WithMany().HasForeignKey(p => p.BrandId);
            builder.Property(product => product.BrandId);
            builder.Property(product => product.VendorId);
            builder.HasOne(product => product.Vendor).WithMany().HasForeignKey(p => p.VendorId);
            builder.Property(product => product.MediaId);
            builder.HasOne(product => product.Media).WithMany().HasForeignKey(p => p.MediaId);
            builder.Property(product => product.SKU).IsRequired();
            builder.Property(product => product.ProductName).HasMaxLength(400).IsRequired();            
            builder.Property(product => product.UnitsOnOrder).IsRequired();
            builder.Property(product => product.QuantityPerUnity).IsRequired();
            builder.Property(product => product.ProductCost).HasColumnType("decimal(18,4)").IsRequired();
            builder.Property(product => product.OldPrice).HasColumnType("decimal(18,4)");
            builder.Property(product => product.Price).HasColumnType("decimal(18,4)"); ;
            builder.Property(product => product.Discount).HasColumnType("decimal(18,4)"); ;                  
            builder.Property(product => product.UnitSize).IsRequired();           
            builder.Property(product => product.UnitPrice).HasColumnType("decimal(18,4)").IsRequired();
            builder.Property(product => product.UnitsInStock).IsRequired();
            builder.Property(product => product.TypeName).IsRequired();
            builder.Property(product => product.Status).IsRequired();            
            base.Configure(builder);
        }             
    }
}
