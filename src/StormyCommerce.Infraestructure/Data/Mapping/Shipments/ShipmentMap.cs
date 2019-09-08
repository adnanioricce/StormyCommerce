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
                //TODO:I think this need some validations
                shipment.Property(prop => prop.TrackNumber).HasMaxLength(250);
                // shipment.Propert(prop => prop)
                shipment.HasData(new Shipment(2)
                {
                    TrackNumber = Guid.NewGuid().ToString(),
                    Comment = "a single comment",
                    DeliveryCost = 22.29m,
                    DeliveryDate = DateTime.Today.AddDays(3),
                    ShippedDate = DateTime.Today.AddDays(-1),
                    Price = 20.99m,
                    TotalWeight = 0.400m,
                    LastModified = DateTime.UtcNow,
                    CreatedOn = DateTime.UtcNow,
                    IsDeleted = false
                });
            });
        }
    }
}
