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
            builder.Property(product => product.ProductName).HasMaxLength(400).IsRequired();
            //builder.Property()
            base.Configure(builder);
        }
    }
}
