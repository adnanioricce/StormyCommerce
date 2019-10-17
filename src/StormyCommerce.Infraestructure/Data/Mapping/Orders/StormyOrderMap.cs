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
                //entity.HasMany(prop => prop.order)
                entity.HasQueryFilter(prop => prop.IsDeleted == false);
            });
            modelBuilder.Entity<StormyOrder>(order =>
            {
                order.HasOne(prop => prop.Payment).WithOne(prop => prop.Order).HasForeignKey<Payment>(prop => prop.StormyOrderId);
                order.HasOne(prop => prop.Shipment).WithOne(prop => prop.Order).HasForeignKey<Shipment>(prop => prop.StormyOrderId);
                // order.HasOne(prop => prop.Customer).WithMany(prop => prop.Orders)
                order.Property(prop => prop.OrderUniqueKey).IsRequired();
                order.Property(prop => prop.PaymentMethod).HasMaxLength(450).IsRequired();
                order.Property(prop => prop.Note).HasMaxLength(1000); 
                // order.Property(prop => prop)               
                order.HasQueryFilter(prop => prop.IsDeleted == false);
                order.Property(prop => prop.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<OrderItem>(orderItem =>
            {
                orderItem.Property(prop => prop.Price)
                    .HasConversion(price => price.Value,dbValue => Price.GetPriceFromString(dbValue));                
                orderItem.HasQueryFilter(prop => prop.IsDeleted == false);
            });
        }
    }
}
