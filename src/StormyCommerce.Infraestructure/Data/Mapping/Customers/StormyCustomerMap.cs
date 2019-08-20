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
                entity.Property(prop => prop.UserId);
                entity.HasOne(prop => prop.DefaultBillingAddress).WithMany().HasForeignKey(customer => customer.DefaultBillingAddressId);
                entity.HasOne(customer => customer.DefaultShippingAddress).WithMany().HasForeignKey(customer => customer.DefaultShippingAddressId);
                entity.Property(prop => prop.FullName).HasMaxLength(450);
                //entity.Property(prop => prop.CPF)
                entity.Ignore(customer => customer.CustomerAddresses);
                //entity.HasData(new StormyCustomer(1)
                //{
                //    UserId = "TODO",                    
                //    IsDeleted = false,
                //    FullName = "Aguinobaldo de Arimateia",
                //    Username = "usernamequalquer",
                //    Email = "aguinaldo@sieu.com",
                //});
            });
            //modelBuilder.Entity<CustomerAddress>(customerAddress =>
            //{
            //    customerAddress.HasData(new CustomerAddress(1)
            //    {
            //        CustomerId = 1,                    
            //    });
            //});
        }
    }
}
