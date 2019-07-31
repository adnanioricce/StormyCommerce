using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Entities.Shipping;

namespace StormyCommerce.Infraestructure.Data.Mapping.Orders
{
    public class StormyOrderMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(prop => prop.Id);
                //entity.HasMany(prop => prop.order)
                entity.HasQueryFilter(prop => prop.IsDeleted == false);
            });
            modelBuilder.Entity<StormyOrder>(order =>
            {
                order.HasOne(prop => prop.Payment).WithOne(prop => prop.Order).HasForeignKey<Payment>(prop => prop.StormyOrderId);
                order.Property(prop => prop.OrderUniqueKey).IsRequired();
                order.Property(prop => prop.PaymentMethod).HasMaxLength(450).IsRequired();
                order.Property(prop => prop.Note).HasMaxLength(1000);
                order.Property(prop => prop.PaymentMethod).HasMaxLength(450);               
                order.HasQueryFilter(prop => prop.IsDeleted == false);
                order.Property(prop => prop.Id).ValueGeneratedOnAdd();
                order.HasData(new StormyOrder(2)
                {
                    OrderUniqueKey = new Guid("16A74211-7773-424B-996E-BC57770A9CEB"),
                    CustomerId = 1,
                    Status = OrderStatus.New,
                    PickUpInStore = false,
                    IsDeleted = false,
                    ShippingMethod = "Sedex",
                    TrackNumber = Guid.NewGuid().ToString("N"),
                    Comment = "meramente demonstrativo",
                    Discount = 0.00m,
                    Tax = 1.01m,
                    TotalWeight = 0.100m,
                    TotalPrice = 34.99m,
                    DeliveryCost = 24.99m,
                    OrderDate = DateTime.Today,
                    DeliveryDate = DateTime.Today.AddDays(7),
                    PaymentDate = DateTime.Today.AddDays(3),
                    PaymentId = 2,
                    RequiredDate = DateTime.Today.AddDays(14),
                    LastModified = DateTime.UtcNow,
                    Note = "a simple note",
                    ShippedDate = DateTime.Today,
                    ShippingStatus = ShippingStatus.Shipped,
                    PaymentMethod = "boleto"                    
                });
            });
            modelBuilder.Entity<OrderItem>(orderItem =>
            {
                orderItem.HasData(new OrderItem(1)
                {                    
                    Quantity = 2,
                    IsDeleted = false,
                    StormyOrderId = 1,
                    StormyProductId = 1,                    
                    LastModified = DateTimeOffset.UtcNow
                });
                orderItem.HasQueryFilter(prop => prop.IsDeleted == false);
            });

                
        }
    }
}
