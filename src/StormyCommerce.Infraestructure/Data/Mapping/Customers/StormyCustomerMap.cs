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
            });
        }
    }
}
