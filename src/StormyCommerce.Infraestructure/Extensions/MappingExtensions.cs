using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Infraestructure.Extensions
{
    public static class MappingExtensions
    {
        public static void MapAddressDetail(this ReferenceOwnershipBuilder<VendorAddress,AddressDetail> builder){
            builder.Property(prop => prop.AddressLine1).HasMaxLength(450);
            builder.Property(prop => prop.AddressLine2).HasMaxLength(450);
            builder.Property(prop => prop.City).HasMaxLength(450);
            builder.Property(prop => prop.CountryCode).HasMaxLength(4);
            builder.Property(prop => prop.DistrictName).HasMaxLength(450);
            builder.Property(prop => prop.Number).HasMaxLength(16);
            builder.Property(prop => prop.ZipCode).HasMaxLength(64);
            builder.Property(prop => prop.State).HasMaxLength(450);
            builder.Property(prop => prop.Complement).HasMaxLength(450);                    
            builder.OwnsOne(prop => prop.Phone,_builder => {
                _builder.Property(prop => prop.DD).HasMaxLength(2);
                _builder.Property(prop => prop.DDI).HasMaxLength(2);
                _builder.Property(prop => prop.Number).HasMaxLength(11);                
            });
        }
        //?Looks like a duplicated code, how I can 'fix' this?
        public static void MapAddressDetail(this ReferenceOwnershipBuilder<CustomerAddress,AddressDetail> builder){
            builder.Property(prop => prop.AddressLine1).HasMaxLength(450);
            builder.Property(prop => prop.AddressLine2).HasMaxLength(450);
            builder.Property(prop => prop.City).HasMaxLength(450);
            builder.Property(prop => prop.CountryCode).HasMaxLength(4);
            builder.Property(prop => prop.DistrictName).HasMaxLength(450);
            builder.Property(prop => prop.Number).HasMaxLength(16);
            builder.Property(prop => prop.ZipCode).HasMaxLength(64);
            builder.Property(prop => prop.State).HasMaxLength(450);
            builder.Property(prop => prop.Complement).HasMaxLength(450);                    
            builder.OwnsOne(prop => prop.Phone,_builder => {
                _builder.Property(prop => prop.DD).HasMaxLength(2);
                _builder.Property(prop => prop.DDI).HasMaxLength(2);
                _builder.Property(prop => prop.Number).HasMaxLength(11);                
            });
        }
    }
}
