﻿using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Models;

namespace StormyCommerce.Infraestructure.Data.Mapping.Orders
{
    public class StormyOrderMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(prop => prop.Id);                
                entity.HasQueryFilter(prop => prop.IsDeleted == false);
            });
            modelBuilder.Entity<StormyOrder>(order =>
            {
                order.HasOne(prop => prop.Payment)
                    .WithOne(prop => prop.Order)
                    .HasForeignKey<Payment>(prop => prop.StormyOrderId);
                order.HasOne(prop => prop.Shipment)
                .WithOne(prop => prop.Order)
                    .HasForeignKey<Shipment>(prop => prop.StormyOrderId);                
                order.Property(prop => prop.OrderUniqueKey).IsRequired();                
                order.Property(prop => prop.Note).HasMaxLength(1000);                 
                order.HasQueryFilter(prop => prop.IsDeleted == false);
                order.Property(prop => prop.Id).ValueGeneratedOnAdd();
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
