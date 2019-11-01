using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using System;

namespace StormyCommerce.Infraestructure.Data.Mapping.Shipments
{
    public class ShipmentMap : IStormyModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipment>(shipment =>
            {                
                shipment.Property(prop => prop.TrackNumber).HasMaxLength(250);
                shipment.HasOne(prop => prop.Order)
                .WithOne(prop => prop.Shipment)
                .HasForeignKey<StormyOrder>(prop => prop.ShipmentId)
                .OnDelete(DeleteBehavior.Restrict);
                shipment.HasOne(prop => prop.BillingAddress)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
                shipment.HasOne(prop => prop.DestinationAddress)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
                shipment
                .HasMany(prop => prop.Items)
                .WithOne(prop => prop.Shipment)
                .HasForeignKey(prop => prop.ShipmentId);                
            });
        }
    }
}
