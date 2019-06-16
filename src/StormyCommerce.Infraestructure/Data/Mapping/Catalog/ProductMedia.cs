using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
   public class ProductMediaMap : EntityTypeConfiguration<ProductMedia>
   {
       public override void Configure(EntityTypeBuilder<ProductMedia> builder)
       {
           builder.ToTable(nameof(ProductMedia));
           builder.HasKey(productMedia => productMedia.Id);
           builder.HasOne(productMedia => productMedia.Media)
           .WithMany()
           .HasForeignKey(p => p.MediaId)
           .HasConstraintName("Media_FK"); 
           builder.HasOne(productMedia => productMedia.Product)
           .WithMany()
           .HasForeignKey(p => p.ProductId)
           .HasForeignKey("product_FK");
           builder.Property(p => p.DisplayOrder); 
           builder.Property(p => p.LastModified);

       }
   }
}