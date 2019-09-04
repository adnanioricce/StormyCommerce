using Microsoft.EntityFrameworkCore;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Common;
using System;

namespace StormyCommerce.Infraestructure.Data.Mapping.Common
{
    public class AddressMap : IStormyModelBuilder
    {
        
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasQueryFilter(prop => !prop.IsDeleted);
                entity.Property(prop => prop.PostalCode).HasMaxLength(9);
                entity.Property(prop => prop.FirstAddress).HasMaxLength(250);
                entity.Property(prop => prop.SecondAddress).HasMaxLength(250);
                entity.Property(prop => prop.City).HasMaxLength(500);
                entity.Property(prop => prop.Complement).HasMaxLength(250);                
                // entity.HasData(Seeders.AddressSeed(5));
                // entity.HasKey(prop => prop.Id);                
            });
        }
    }
}
