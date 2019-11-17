using System;

using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Infraestructure.Data.Mapping.Customers
{
    public class WishListMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.HasKey(prop => prop.Id);
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
                entity.HasOne(p => p.Customer)
                .WithOne()
                .HasForeignKey<StormyCustomer>(c => c.CustomerWishlistId)
                .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(prop => prop.WishlistItems)
                .WithOne(prop => prop.Wishlist)
                .HasForeignKey(prop => prop.WishlistId)
                .OnDelete(DeleteBehavior.Restrict);
                entity.HasQueryFilter(prop => !prop.IsDeleted);
            });
            modelBuilder.Entity<WishlistItem>(entity =>
            {
                entity.HasKey(prop => prop.Id );
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
                entity.HasOne(prop => prop.Product)
                .WithMany()
                .HasForeignKey(prop => prop.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(prop => prop.Wishlist)
                .WithMany()
                .HasForeignKey(prop => prop.WishlistId)
                .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
