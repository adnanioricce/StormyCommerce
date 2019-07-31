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
                entity.HasMany(prop => prop.CustomerAddresses).WithOne(prop => prop.Customer);
                entity.Property(prop => prop.UserId);
                entity.HasData(new StormyCustomer(1)
                {
                    UserId = "TODO",                    
                    IsDeleted = false,
                    FullName = "Aguinobaldo de Arimateia",
                    Username = "usernamequalquer",
                    Email = "aguinaldo@sieu.com",
                });
            });
            modelBuilder.Entity<CustomerAddress>(customerAddress =>
            {
                customerAddress.HasData(new CustomerAddress(1)
                {
                    CustomerId = 1,                    
                });
            });
        }
    }
}
