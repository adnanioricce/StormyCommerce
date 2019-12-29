using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.User;

namespace StormyCommerce.Infraestructure.Data.Mapping.User
{
    public class UserRoleMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>(entity => {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("Core_UserRole");

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);                

                entity.HasOne(ur => ur.User)
                    .WithMany(x => x.Roles)
                    .HasForeignKey(u => u.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);                    
            });
        }
    }
}
