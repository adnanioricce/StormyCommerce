using Microsoft.EntityFrameworkCore;
using StormyCommerce.Api.Framework;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Extensions;

namespace StormyCommerce.Infraestructure.Data.Mapping.Customers
{
    public class StormyCustomerMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<StormyCustomer>(entity =>
            {                               
                entity.HasOne(prop => prop.CustomerWishlist).WithOne(prop => prop.Customer);
                entity.HasMany(prop => prop.CustomerReviews).WithOne(prop => prop.Author).HasForeignKey(prop => prop.StormyCustomerId);
                entity.HasOne(prop => prop.DefaultBillingAddress).WithMany().HasForeignKey(customer => customer.DefaultBillingAddressId);
                entity.HasOne(customer => customer.DefaultShippingAddress).WithMany().HasForeignKey(customer => customer.DefaultShippingAddressId);
                entity.Property(prop => prop.FullName).HasMaxLength(450);
                entity.Property(prop => prop.CPF).HasMaxLength(9);
                entity.Ignore(customer => customer.CustomerAddresses);                
            });
            modelBuilder.Entity<ApplicationUser>(entity => {
                entity.HasKey(prop => prop.Id);                         
            });
            modelBuilder.Entity<Review>(entity => {
                entity.HasOne(prop => prop.Author).WithMany(customer => customer.CustomerReviews).HasForeignKey(r => r.StormyCustomerId);                                
                entity.HasQueryFilter(prop => !prop.IsDeleted);
            });   
            modelBuilder.Entity<Wishlist>(entity => {
                entity.HasOne(p => p.Customer).WithOne(p => p.CustomerWishlist);
                entity.HasMany(prop => prop.WishlistItems).WithOne(prop => prop.Wishlist).HasForeignKey(prop => prop.WishlistId);
                entity.HasQueryFilter(prop => !prop.IsDeleted);
                // entity.Property(prop => prop.)
            });         
            
        }
    }
}
