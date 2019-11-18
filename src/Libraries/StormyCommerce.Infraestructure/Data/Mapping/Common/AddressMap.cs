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
                entity.OwnsOne(prop => prop.Address);
                // entity
                //     .HasOne(prop => prop.Owner)
                //     .WithMany()                    
                //     .HasForeignKey(prop => prop.UserId)
                //     .OnDelete(DeleteBehavior.Cascade);
                // entity.HasOne(prop => prop.Owner)
                //     .WithOne()
                //     .HasForeignKey(nameof(StormyCustomer.DefaultBillingAddressId))
                //     .OnDelete(DeleteBehavior.Restrict);
                // entity.HasOne(typeof(StormyCustomer))
                //     .WithOne()
                //     .HasForeignKey(nameof(StormyCustomer.DefaultShippingAddressId))                                        
                //     .OnDelete(DeleteBehavior.Restrict);                                 
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();                                
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
