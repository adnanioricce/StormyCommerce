using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Infraestructure.Data.Mapping.Wishlist
{
    public class WishlistMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Core.Entities.Customer.Wishlist>(entity =>
            {
                entity.ToTable("WishList_WishList");

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.CreatedOn).HasColumnType("timestamp with time zone");

                entity.Property(e => e.LastModified).HasColumnType("timestamp with time zone");

                entity.Property(e => e.SharingCode).HasMaxLength(450);
                entity.HasMany(d => d.Items)
                    .WithOne()
                    .HasForeignKey(d => d.WishlistId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(p => p.User)
                    .WithOne(d => d.CustomerWishlist)
                    .HasForeignKey<Core.Entities.Customer.Wishlist>(p => p.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
