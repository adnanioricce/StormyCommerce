using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;

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
                entity.HasMany(prop => prop.Addresses)
                    .WithOne(prop => prop.Owner)
                    .HasForeignKey(prop => prop.UserId);
                entity
                    .HasOne(prop => prop.DefaultBillingAddress)
                    .WithMany()
                    .HasForeignKey(customer => customer.DefaultBillingAddressId)                                    
                    .OnDelete(DeleteBehavior.Restrict);
                entity
                    .HasOne(customer => customer.DefaultShippingAddress)
                    .WithMany()
                    .HasForeignKey(customer => customer.DefaultShippingAddressId)                    
                    .OnDelete(DeleteBehavior.Restrict);
                entity
                    .HasIndex(prop => prop.DefaultBillingAddressId)
                    .IsUnique(false);
                entity
                    .HasIndex(prop => prop.DefaultShippingAddressId)
                    .IsUnique(false);
                entity.Property(prop => prop.FullName).HasMaxLength(450);
                entity.Property(prop => prop.CPF).HasMaxLength(9);
                entity.Property(prop => prop.Email).IsRequired();                
                entity.Ignore(customer => customer.Addresses);

                //Identity Mapping               
                // Each User can have many entries in the UserRole join table
                // entity.HasMany(e => e.UserRoles)
                //     .WithOne(e => e.User)
                //     .HasForeignKey(ur => ur.UserId)
                //     .IsRequired();
                entity.HasOne(prop => prop.Role)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            });                       
            modelBuilder.Entity<ApplicationRole>(entity => {
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
                // entity.HasMany(e => e.UserRoles)
                // .WithOne(e => e.Role)
                // .HasForeignKey(ur => ur.RoleId)
                // .IsRequired();
                // entity.HasMany<ApplicationUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

                // Each Role can have many associated RoleClaims
                // b.HasMany<TRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();
            });            
            // modelBuilder.Entity<ApplicationUserRole>(entity => {                
            //     entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
            //     entity.HasKey(e => new {e.UserId,e.Id});
            // });
            
        }
    }
}
