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
                entity.HasQueryFilter(p => !p.IsDeleted);                     
                entity.HasKey(prop => prop.Id);
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();                                       
                entity.HasOne(prop => prop.Address).WithOne().OnDelete(DeleteBehavior.Cascade);
                entity.HasMany(prop => prop.Products).WithOne().OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
