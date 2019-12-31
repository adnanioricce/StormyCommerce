using Microsoft.EntityFrameworkCore;


namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    public class BrandMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Brand>(entity =>
            //{
            //    entity.ToTable("Catalog_Brand");

            //    entity.HasKey(prop => prop.Id);

            //    entity.Property(prop => prop.Id)
            //        .ValueGeneratedOnAdd();
                
            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(450);

            //    entity.Property(e => e.Slug)
            //        .IsRequired()
            //        .HasMaxLength(450);

            //    entity.HasQueryFilter(brand => !brand.IsDeleted)
            //        .Property(brand => brand.Slug)
            //        .HasMaxLength(450)
            //        .IsRequired();                
            //});
        }
    }
}
