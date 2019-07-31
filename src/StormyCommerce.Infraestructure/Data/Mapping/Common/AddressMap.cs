using Microsoft.EntityFrameworkCore;
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
                entity.HasData(new Address(2)
                {
                   City = "NoWhere",
                   Complement = "A simple complement",
                   FirstAddress = "first Address",
                   LastModified = DateTime.UtcNow,
                   Number = Guid.NewGuid().ToString("N"),
                   PhoneNumber = "9999999-11",
                   PostalCode = "12345678-9",
                   SecondAddress = "Second Address",
                   State = "Hell",
                   Street = "Mcdonalds",                    
                });
            });
        }
    }
}
