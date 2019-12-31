using Microsoft.EntityFrameworkCore;


namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    public class ProductTemplateProductAttributeMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {                       
            modelBuilder.Entity<ProductTemplateProductAttribute>(entity =>
            {
                entity.HasKey(t => new { t.ProductTemplateId, t.ProductAttributeId });

                entity.HasOne(pt => pt.ProductTemplate)
                .WithMany(p => p.ProductAttributes)
                .HasForeignKey(pt => pt.ProductTemplateId)
                .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(pt => pt.ProductAttribute)
                .WithMany(t => t.ProductTemplates)
                .HasForeignKey(pt => pt.ProductAttributeId)
                .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
