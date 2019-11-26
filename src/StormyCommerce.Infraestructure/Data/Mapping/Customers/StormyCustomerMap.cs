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
                //entity.HasMany(prop => prop.Addresses)
                //    .WithOne(prop => prop.Owner)
                //    .HasForeignKey(prop => prop.UserId);
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
                //entity.Ignore(customer => customer.Addresses);                
                entity.HasOne(prop => prop.Role)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            });            
            modelBuilder.Entity<ApplicationRole>(entity => {
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();                
            });                        
            
        }
    }
}
