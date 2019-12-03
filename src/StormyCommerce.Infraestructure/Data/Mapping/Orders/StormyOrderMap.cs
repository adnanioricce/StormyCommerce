using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Models;

namespace StormyCommerce.Infraestructure.Data.Mapping.Orders
{
    public class StormyOrderMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StormyPayment>(entity =>
            {
                entity.HasKey(prop => prop.Id);                
                entity.HasQueryFilter(prop => prop.IsDeleted == false);                
            });
            modelBuilder.Entity<StormyOrder>(order =>
            {
                order.HasOne(prop => prop.Payment)
                    //.WithOne(prop => prop.Order)
                    .WithOne()
                    .HasForeignKey<StormyPayment>(prop => prop.StormyOrderId)
                    .OnDelete(DeleteBehavior.Restrict);
                order.HasOne(prop => prop.Shipment)
                    .WithOne(prop => prop.Order)
                    .HasForeignKey<StormyShipment>(prop => prop.StormyOrderId)
                    .OnDelete(DeleteBehavior.Restrict);
                order.HasOne(prop => prop.Customer)
                .WithMany()
                .HasForeignKey(prop => prop.StormyCustomerId)
                .OnDelete(DeleteBehavior.Restrict);                
                order.Property(prop => prop.OrderUniqueKey).IsRequired();                
                order.Property(prop => prop.Note).HasMaxLength(1000);                 
                order.HasQueryFilter(prop => prop.IsDeleted == false);
                order.Property(prop => prop.Id).ValueGeneratedOnAdd().UseNpgsqlIdentityByDefaultColumn();
            });
            modelBuilder.Entity<OrderItem>(orderItem =>
            {
                // orderItem.HasKey(prop => new {prop.Id,prop.StormyOrderId});
                orderItem.HasOne(prop => prop.Order).WithMany(order => order.Items).HasForeignKey(o => o.StormyOrderId);
                orderItem.Property(prop => prop.Price);                    
                orderItem.HasQueryFilter(prop => prop.IsDeleted == false);
            });
        }
    }
}
