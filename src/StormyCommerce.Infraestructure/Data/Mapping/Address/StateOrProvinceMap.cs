using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Address;

namespace StormyCommerce.Infraestructure.Data.Mapping.Address
{
    public class StateOrProvinceMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StateOrProvince>(entity =>
            {
                entity.ToTable("Core_StateOrProvince");

                entity.HasIndex(e => e.CountryId);
                
                entity.Property(prop => prop.CountryId)
                    .HasMaxLength(450)
                    .IsRequired();
                
                entity.Property(prop => prop.Code)
                    .HasMaxLength(450);
                
                entity.Property(prop => prop.Name)
                    .HasMaxLength(450)
                    .IsRequired();
                
                entity.Property(prop => prop.Type)
                    .HasMaxLength(450);
                
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StatesOrProvinces)
                    .HasForeignKey(d => d.CountryId);
            });
        }
    }
}
