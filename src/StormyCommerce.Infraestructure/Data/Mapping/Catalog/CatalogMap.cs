using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimplCommerce.Infrastructure.Data;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    //!I Decided not use Widgets for now, maybe I change my mind
    public class ProductMap : EntityTypeConfiguration<StormyProduct>,ICustomModelBuilder
    {        
        public override void ApplyConfiguration(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<EntityType>().HasData(
                new EntityType("Category") { AreaName = "Catalog", RoutingController = "Category", RoutingAction = "CategoryDetail", IsMenuable = true },
                new EntityType("Brand") { AreaName = "Catalog", RoutingController = "Brand", RoutingAction = "BrandDetail", IsMenuable = true },
                new EntityType("Product") { AreaName = "Catalog", RoutingController = "Product", RoutingAction = "ProductDetail", IsMenuable = false }
            );

            modelBuilder.Entity<ProductOption>().HasData(
                new ProductOption(1) { Name = "Color" },
                new ProductOption(2) { Name = "Size" }
            );
        }
        public void Build(ModelBuilder modelBuilder)
        {                                            
            modelBuilder.ApplyConfiguration(this);
        }

        public override void Configure(EntityTypeBuilder<StormyProduct> builder)
        {
            builder.ToTable(nameof(StormyProduct));
            builder.HasKey(product => product.Id);            
            builder.HasOne(product => product.Brand).WithMany().HasForeignKey(p => p.BrandId).HasConstraintName("Brand_Fk");
            builder.Property(product => product.BrandId).HasColumnName("Brand_Id");
            builder.Property(product => product.VendorId).HasColumnName("Vendor_Id");
            builder.HasOne(product => product.Vendor).WithMany().HasForeignKey(p => p.VendorId).HasConstraintName("Vendor_Fk");
            builder.Property(product => product.MediasId).HasColumnName("Product_Medias_Id");            
            builder.HasOne(product => product.Medias).WithMany().HasForeignKey(p => p.MediasId).HasConstraintName("Product_Medias_Fk");            
            builder.Property(product => product.SKU).IsRequired();
            builder.Property(product => product.ProductName).HasMaxLength(400).IsRequired();
            builder.Property(product => product.AllowCustomerReview);
            builder.Property(product => product.AvailableForPreorder);
            builder.Property(product => product.Deleted);
            builder.Property(product => product.DiscountAvailable);
            builder.Property(product => product.HasDiscountApplied);
            builder.Property(product => product.ProductAvailable).IsRequired();
            builder.Property(product => product.NotReturnable).IsRequired();
            builder.Property(product => product.Published);
            builder.Property(product => product.AvailableForPreorder);
            builder.Property(product => product.ApprovedRatingSum);
            builder.Property(product => product.ApprovedTotalReviews);
            builder.Property(product => product.CreatedAt).IsRequired();
            builder.Property(product => product.LastModified);
            builder.Property(product => product.PreOrderAvailabilityStartDate);
            builder.Property(product => product.UpdatedOnUtc);
            builder.Property(product => product.CurrentOrder);
            builder.Property(product => product.UnitsOnOrder).IsRequired();
            builder.Property(product => product.QuantityPerUnity).IsRequired();
            builder.Property(product => product.ProductCost).HasColumnType("decimal(18,4)").IsRequired();
            builder.Property(product => product.OldPrice).HasColumnType("decimal(18,4)");
            builder.Property(product => product.Price).HasColumnType("decimal(18,4)"); ;
            builder.Property(product => product.Discount).HasColumnType("decimal(18,4)"); ;
            builder.Property(product => product.NotApprovedRatingSum);
            builder.Property(product => product.NotApprovedTotalReviews);            
            builder.Property(product => product.Ranking);
            builder.Property(product => product.UnitSize).IsRequired();
            builder.Property(product => product.UnitWeight);            
            builder.Property(product => product.UnitPrice).HasColumnType("decimal(18,4)").IsRequired();
            builder.Property(product => product.UnitsInStock).IsRequired();
            builder.Property(product => product.TypeName).IsRequired();
            builder.Property(product => product.Status).IsRequired();
            builder.Property(product => product.Note);  
            // builder.Property(product => product.AttributeValues)
            base.Configure(builder);        
        }
    }
}
