using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Vendor;

namespace StormyCommerce.Infraestructure.Data.Mapping.Vendors
{
    public class StormyVendorMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StormyVendor>(entity =>
            {
                entity.ToTable("Core_Vendor");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.LastModified)
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasQueryFilter(p => !p.IsDeleted);                     

                entity.HasKey(prop => prop.Id);

                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();                                       

                entity.HasMany(prop => prop.Addresses)
                    .WithOne()
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasMany(prop => prop.Products)
                    .WithOne()
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
