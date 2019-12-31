using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Infraestructure.Data;

namespace SimplCommerce.Module.Core.Data.Mapping
{
    public class VendorMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Core_Vendor");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.LatestUpdatedOn)
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

                entity.HasMany("Product")
                    .WithOne()
                    .HasForeignKey("ProductId")
                    .OnDelete(DeleteBehavior.Restrict);
            });        
        }
    }
}
