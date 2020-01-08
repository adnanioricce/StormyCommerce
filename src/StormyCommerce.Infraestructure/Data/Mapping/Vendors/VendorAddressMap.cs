using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Infraestructure.Extensions;

namespace StormyCommerce.Infraestructure.Data.Mapping.Vendors
{
    public class VendorAddressMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<VendorAddress>(entity => {                
                entity.OwnsOne(prop => prop.Address,a => a.MapAddressDetail());
            });
        }
    }
}
