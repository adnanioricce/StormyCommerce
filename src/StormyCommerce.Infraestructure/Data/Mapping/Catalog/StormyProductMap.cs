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
                entity.HasKey(prop => prop.Id);
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
                entity.HasQueryFilter(product => !product.IsDeleted);                
                entity.Property(product => product.BrandId);
                entity.HasOne(product => product.Brand).WithMany().HasForeignKey(p => p.BrandId);                
                entity.HasOne(product => product.Vendor).WithMany(prop => prop.Products).HasForeignKey(p => p.VendorId);                
                entity.HasMany(product => product.Medias).WithOne().HasForeignKey(m => m.StormyProductId).OnDelete(DeleteBehavior.Cascade);
                entity.HasMany(product => product.Links).WithOne(l => l.Product).HasForeignKey(l => l.ProductId);
                entity.HasOne(product => product.Category).WithOne();
                entity.Property(product => product.SKU).IsRequired();
                entity.Property(product => product.ProductName).HasMaxLength(400).IsRequired();                
                entity.Property(product => product.QuantityPerUnity).IsRequired();
                entity.Property(product => product.ProductCost).IsRequired();
                entity.Ignore(product => product.Price);
                entity.Ignore(product => product.OldPrice);
                entity.Property(product => product.UnitPrice).IsRequired();
                entity.Property(product => product.UnitsInStock).IsRequired();                
            });

            modelBuilder.Entity<ProductOption>(entity =>
            {
            });
            modelBuilder.Entity<ProductMedia>(entity =>
            {                
                entity.HasKey(prop => prop.Id);                
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();                                              
            });
            modelBuilder.Entity<Stock>(e => { 
                e.Property(prop => prop.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(prop => prop.Id); 
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
                entity.HasQueryFilter(brand => !brand.IsDeleted)
                .Property(brand => brand.Slug)
                .HasMaxLength(450)
                .IsRequired();                
            });
        }
    }
}
