using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Address;

namespace StormyCommerce.Infraestructure.Data.Mapping.Address
{
    public class DistrictMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District>(entity =>
            {
                entity.HasIndex(prop => prop.StateOrProvinceId);                
                entity.Property(prop => prop.Name)
                    .IsRequired()
                    .HasMaxLength(450);
                entity.Property(prop => prop.Type)
                    .HasMaxLength(450);
                entity.HasOne(d => d.StateOrProvince)
                    .WithMany()
                    .HasForeignKey(d => d.StateOrProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
