using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    public class ProductLinkMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductLink>(entity =>
            {
                entity.HasOne(x => x.Product)
                    .WithMany()
                    .HasForeignKey(x => x.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(x => x.Product)
                    .WithMany(p => p.Links)
                    .HasForeignKey(x => x.ProductId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
