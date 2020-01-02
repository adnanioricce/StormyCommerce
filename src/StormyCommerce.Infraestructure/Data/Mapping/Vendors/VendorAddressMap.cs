using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Infraestructure.Data.Mapping.Vendors
{
    public class VendorAddressMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<VendorAddress>((System.Action<Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VendorAddress>>)(entity => {                
                entity.OwnsOne((System.Linq.Expressions.Expression<System.Func<VendorAddress, Core.Entities.Common.AddressDetail>>)(prop => (Core.Entities.Common.AddressDetail)prop.Address));
            }));
        }
    }
}
