using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Api.Framework.Extensions;
namespace StormyCommerce.Infraestructure.Data.Mapping.Vendors
{
    public class StormyVendorMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StormyVendor>(entity =>
            {
                //entity.HasData(Seeders.StormyVendorSeed(20));
            });
        }
    }
}
