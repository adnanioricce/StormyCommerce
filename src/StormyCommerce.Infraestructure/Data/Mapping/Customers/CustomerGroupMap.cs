using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Infraestructure.Data.Mapping.Customers
{
    public class CustomerGroupMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerGroup>(entity => {
                entity.ToTable("Core_CustomerGroup");

                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.LatestUpdatedOn)
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);
            });
        }
    }
}
