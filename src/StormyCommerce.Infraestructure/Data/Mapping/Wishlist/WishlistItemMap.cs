using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Infraestructure.Data.Mapping.Wishlist
{
    public class WishlistItemMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WishlistItem>(entity =>
            {
                entity.ToTable("WishList_WishListItem");

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.WishlistId);

                entity.Property(e => e.AddedAt).HasColumnType("timestamp with time zone");

                entity.Property(e => e.LatestUpdatedOn).HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(d => d.Wishlist)
                    .WithMany()
                    .HasForeignKey(d => d.WishlistId)
                    .OnDelete(DeleteBehavior.ClientSetNull);                
            });
        }
    }
}
