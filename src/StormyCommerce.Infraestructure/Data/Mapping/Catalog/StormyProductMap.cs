using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StormyCommerce.Core.Entities.Product;

namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    public class StormyProductMap : EntityTypeConfiguration<StormyProduct>
    {
        public override void Configure(EntityTypeBuilder<StormyProduct> builder)
        {
            builder.ToTable(nameof(StormyProduct));
            builder.HasKey(product => product.Id);
            builder.HasOne(product => product.Brand).WithMany().HasForeignKey(p => p.BrandId).HasConstraintName("Brand_Fk");
            builder.Property(product => product.BrandId).HasColumnName("Brand_Id");
            builder.Property(product => product.VendorId).HasColumnName("Vendor_Id");
            builder.HasOne(product => product.Vendor).WithMany().HasForeignKey(p => p.VendorId).HasConstraintName("Vendor_Fk");
            builder.Property(product => product.ProductPicturesId).HasColumnName("Product_Pictures_Id");
            builder.HasOne(product => product.Pictures).WithMany().HasForeignKey(p => p.ProductPicturesId).HasConstraintName("Product_Pictures_Fk");
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
            base.Configure(builder);
        }
    }
}
