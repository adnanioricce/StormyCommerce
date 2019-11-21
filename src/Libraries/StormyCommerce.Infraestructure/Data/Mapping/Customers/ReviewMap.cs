using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;

namespace StormyCommerce.Infraestructure.Data.Mapping.Customers
{
    public class ReviewMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(prop => prop.Id);
                entity.HasOne(prop => prop.Author)
                    .WithMany(customer => customer.CustomerReviews)
                    .HasForeignKey(prop => prop.StormyCustomerId)                    
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
                entity.HasOne(prop => prop.Product)
                .WithMany()
                .HasForeignKey(prop => prop.StormyProductId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
                entity.Property(prop => prop.Id).ValueGeneratedOnAdd();
                entity.HasQueryFilter(prop => prop.IsDeleted == false);
            });
        }
    }
}
