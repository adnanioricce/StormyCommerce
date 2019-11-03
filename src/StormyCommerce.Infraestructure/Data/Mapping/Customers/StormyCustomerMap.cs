using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Infraestructure.Entities;

namespace StormyCommerce.Infraestructure.Data.Mapping.Customers
{
    public class StormyCustomerMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StormyCustomer>(entity =>
            {                                
                entity.HasKey(prop => prop.Id);
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
                entity.Property(prop => prop.UserId).ValueGeneratedOnAdd();
                entity.HasQueryFilter(f => f.IsDeleted == false);                                
                entity
                    .HasOne(prop => prop.CustomerWishlist)
                    .WithOne(prop => prop.Customer)
                    .HasForeignKey<Wishlist>(prop => prop.StormyCustomerId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity
                    .HasMany(prop => prop.CustomerReviews)
                    .WithOne(prop => prop.Author)
                    .HasForeignKey(prop => prop.StormyCustomerId)
                    .HasPrincipalKey(prop => prop.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasMany(prop => prop.Addresses)
                    .WithOne(prop => prop.Owner)
                    .HasForeignKey(prop => prop.UserId);
                entity
                    .HasOne(prop => prop.DefaultBillingAddress)
                    .WithMany()
                    .HasForeignKey(customer => customer.DefaultBillingAddressId)                                    
                    .OnDelete(DeleteBehavior.Cascade);
                entity
                    .HasOne(customer => customer.DefaultShippingAddress)
                    .WithMany()
                    .HasForeignKey(customer => customer.DefaultShippingAddressId)                    
                    .OnDelete(DeleteBehavior.Cascade);
                entity
                    .HasIndex(prop => prop.DefaultBillingAddressId)
                    .IsUnique(false);
                entity.HasIndex(prop => prop.DefaultShippingAddressId).IsUnique();
                entity.Property(prop => prop.FullName).HasMaxLength(450);
                entity.Property(prop => prop.CPF).HasMaxLength(9);
                entity.Property(prop => prop.Email).IsRequired();
                entity.Ignore(customer => customer.Addresses);
            });            
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.HasKey(prop => prop.Id);                
                entity.HasOne(prop => prop.Role);
            });
            modelBuilder.Entity<ApplicationRole>();
            modelBuilder.Entity<Review>(entity =>
            {                
                entity.HasKey(prop => prop.Id);
                entity.HasOne(prop => prop.Author)
                    .WithMany(customer => customer.CustomerReviews)
                    .HasForeignKey(prop => prop.StormyCustomerId)
                    .HasPrincipalKey(prop => prop.UserId);
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
                entity.HasQueryFilter(prop => prop.IsDeleted == false);                
            });
            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.HasKey(prop => new {prop.Id,prop.StormyCustomerId});
                entity.HasOne(p => p.Customer).WithOne(p => p.CustomerWishlist).HasPrincipalKey<StormyCustomer>(c => c.Id);
                entity.HasMany(prop => prop.WishlistItems).WithOne(prop => prop.Wishlist).HasPrincipalKey(prop => prop.Id);
                entity.HasQueryFilter(prop => !prop.IsDeleted);
            });
        }
    }
}
