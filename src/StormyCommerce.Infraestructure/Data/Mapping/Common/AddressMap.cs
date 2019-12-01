using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Vendor;

namespace StormyCommerce.Infraestructure.Data.Mapping.Common
{
    public class AddressMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasQueryFilter(prop => !prop.IsDeleted);
                entity.HasKey(prop => prop.Id);                                                                
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
                entity.HasOne(prop => prop.Owner)
                .WithMany()
                .HasForeignKey(prop => prop.StormyCustomerId)
                .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<VendorAddress>(entity => {
                entity
                .HasOne(prop => prop.Owner)
                .WithOne(prop => prop.Address)
                .HasForeignKey<StormyVendor>(prop => prop.VendorAddressId);
                entity.OwnsOne(prop => prop.Address);
            });
        }
    }
}
