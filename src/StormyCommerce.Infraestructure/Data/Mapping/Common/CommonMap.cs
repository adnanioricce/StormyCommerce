﻿using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Vendor;

namespace StormyCommerce.Infraestructure.Data.Mapping.Common
{
    public class CommonMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<VendorAddress>((System.Action<Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VendorAddress>>)(entity => {
                entity
                .HasOne(prop => prop.Owner)
                .WithOne(prop => prop.Address)
                .HasForeignKey<StormyVendor>(prop => prop.VendorAddressId);
                entity.OwnsOne((System.Linq.Expressions.Expression<System.Func<VendorAddress, Core.Entities.Common.AddressDetail>>)(prop => (Core.Entities.Common.AddressDetail)prop.Address));
            }));
        }
    }
}
