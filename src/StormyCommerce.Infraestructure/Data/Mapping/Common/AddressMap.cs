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
                entity.HasData(Seeders.AddressSeed(5));
                // entity.HasKey(prop => prop.Id);                
            });
        }
    }
}
