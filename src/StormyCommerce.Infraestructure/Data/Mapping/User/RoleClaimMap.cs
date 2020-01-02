using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Infraestructure.Data.Mapping.User
{
    public class RoleClaimMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleClaim>(entity =>
            {
                entity.ToTable("Core_RoleClaim");

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany()
                    .HasForeignKey(d => d.RoleId);
            });           
        }
    }
}
