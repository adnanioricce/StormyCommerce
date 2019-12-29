using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Models;

namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    //!I Decided not use Widgets for now, maybe I change my mind
    public class StormyProductMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {                                               
            
            modelBuilder.Entity<StormyProduct>(entity =>
            {
                entity.HasKey(prop => prop.Id);
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
                entity.HasQueryFilter(product => !product.IsDeleted);                                
                                                                       
                entity.Property(product => product.SKU)
                    .IsRequired();
                entity.Property(product => product.ProductName)
                    .HasMaxLength(400)
                    .IsRequired();                
                entity.Property(product => product.QuantityPerUnity)
                    .IsRequired();
                entity.Property(product => product.ProductCost)
                    .IsRequired();
                entity.Ignore(product => product.Price);                
                entity.Property(product => product.UnitPrice)
                    .IsRequired();
                entity.Property(product => product.UnitsInStock)
                    .IsRequired();
                entity.HasOne(product => product.Brand)
                    .WithMany()
                    .HasForeignKey(p => p.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });                                                
            
            
        }
    }
}
