using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Infraestructure.Data.Mapping.User
{
    public class RoleMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Core_Role");

                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });
        }
    }
}
