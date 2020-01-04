using Microsoft.EntityFrameworkCore;


namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    public class ProductCategoryMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProductCategory>(entity => {
            //    entity.HasKey(prop => prop.Id);
            //    entity.HasOne(prop => prop.Product)
            //    .WithMany(prop => prop.Categories)
            //    .HasForeignKey(prop => prop.ProductId)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .IsRequired();
            //    entity.HasOne(prop => prop.Category)
            //    .WithMany()
            //    .HasForeignKey(prop => prop.CategoryId)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    .IsRequired();
            //});
        }
    }
}
