using System;
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
                entity.HasData(new StormyVendor(1)
                {                          
                   AddressId = 1,
                   CompanyName = "SimpleCompany",
                   ContactTitle = "Simple and a bit trustful",
                   TypeGoods = "Fashion",
                   WebSite = "www.simplecompanyonweb.com",
                   Email = "simplecompany@simpl.com",
                   LastModified = DateTime.UtcNow,
                   Logo = "no image",
                   Phone = "8887445512-11",
                   SizeUrl = "www.sizes.com",
                   Note = "Sample Data"                    
                });
            });
        }
    }
}
