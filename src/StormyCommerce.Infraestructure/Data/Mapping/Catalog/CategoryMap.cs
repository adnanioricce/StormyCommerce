using Microsoft.EntityFrameworkCore;


namespace StormyCommerce.Infraestructure.Data.Mapping.Catalog
{
    public class CategoryMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>(builder =>
            //{
            //    builder.ToTable("Catalog_Category");

            //    builder.HasIndex(e => e.ParentId);

            //    builder.HasIndex(e => e.ThumbnailImageId);

            //    builder.Property(e => e.MetaKeywords).HasMaxLength(450);

            //    builder.Property(e => e.MetaTitle).HasMaxLength(450);

            //    builder.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(450);

            //    builder.Property(e => e.Slug)
            //        .IsRequired()
            //        .HasMaxLength(450);                

            //    builder.HasOne(d => d.ThumbnailImage)
            //        .WithMany()
            //        .HasForeignKey(d => d.ThumbnailImageId);
            //    builder.HasQueryFilter(category => category.IsDeleted == false);
            //    builder.HasKey(category => category.Id);                
            //    builder.Property(category => category.Name).HasMaxLength(450).IsRequired();
            //    builder.Property(category => category.Slug).HasMaxLength(450).IsRequired();                
            //    builder.Property(category => category.Description).HasMaxLength(450).IsRequired();                
            //});
        }
    }
}
