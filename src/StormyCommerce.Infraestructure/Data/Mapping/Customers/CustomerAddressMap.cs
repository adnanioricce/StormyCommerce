using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Infraestructure.Data.Mapping.Customers
{
    public class CustomerAddressMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerAddress>(customerAddress =>
            {
                customerAddress.HasOne(prop => prop.Customer);
                //customerAddress.HasOne(prop => prop.c)
            });
        }
    }
}
