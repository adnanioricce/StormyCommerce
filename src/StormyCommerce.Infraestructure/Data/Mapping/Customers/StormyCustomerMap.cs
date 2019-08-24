using Microsoft.EntityFrameworkCore;
using StormyCommerce.Api.Framework;
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
                entity.HasOne(prop => prop.DefaultBillingAddress).WithMany().HasForeignKey(customer => customer.DefaultBillingAddressId);
                entity.HasOne(customer => customer.DefaultShippingAddress).WithMany().HasForeignKey(customer => customer.DefaultShippingAddressId);
                entity.Property(prop => prop.FullName).HasMaxLength(450);
                entity.Property(prop => prop.CPF).HasMaxLength(11);
                entity.Ignore(customer => customer.CustomerAddresses);                
            });
            modelBuilder.Entity<ApplicationUser>(entity => {
                entity.HasKey(prop => prop.Id);                         
            });
            
        }
    }
}
