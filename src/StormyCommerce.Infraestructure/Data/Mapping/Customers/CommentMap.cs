using System;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Infraestructure.Data.Mapping.Customers
{
    public class CommentMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>(entity => {
                entity.Property(prop => prop.Title).HasMaxLength(450).IsRequired();
                entity.Property(prop => prop.Body).HasMaxLength(450);
                entity.HasQueryFilter(prop => !prop.IsDeleted); 
                entity.HasOne(prop => prop.Customer)
                .WithMany()
                .HasForeignKey(prop => prop.StormyCustomerId)
                .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(prop => prop.Product)
                .WithMany()
                .HasForeignKey(prop => prop.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
                
            });
        }
    }
}
