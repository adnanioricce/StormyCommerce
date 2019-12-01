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
                entity.Property(prop => prop.FullName).HasMaxLength(450);
                entity.Property(prop => prop.CPF).HasMaxLength(9);
                entity.Property(prop => prop.Email).IsRequired();                                              
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
