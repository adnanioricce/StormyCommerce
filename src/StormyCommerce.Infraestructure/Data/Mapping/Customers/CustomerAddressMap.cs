using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Infraestructure.Extensions;

namespace StormyCommerce.Infraestructure.Data.Mapping.Customers
{
    public class CustomerAddressMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAddress>(entity => {
                entity.ToTable("Core_CustomerAddress");                

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LastUsedOn).HasColumnType("timestamp with time zone");

                entity.HasQueryFilter(prop => !prop.IsDeleted);

                entity.HasKey(prop => prop.Id);                                                                

                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();

                entity.HasOne(prop => prop.Owner)
                    .WithMany()
                    .HasForeignKey(prop => prop.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.OwnsOne(prop => prop.Details,b => b.MapAddressDetail());
            });
        }
    }
}
