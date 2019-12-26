using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Infraestructure.Data.Mapping.Customers
{
    public class CustomerGroupUserMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerGroupUser>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CustomerGroupId });

                entity.ToTable("Core_CustomerGroupUser");

                entity.HasIndex(e => e.CustomerGroupId);
                
                entity.HasOne(ur => ur.User)
                    .WithMany(r => r.CustomerGroups)
                    .HasForeignKey(r => r.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(ur => ur.CustomerGroup)
                    .WithMany(u => u.Users)
                    .HasForeignKey(u => u.CustomerGroupId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.ToTable("Core_CustomerGroupUser");
            });                      
        }
    }
}
