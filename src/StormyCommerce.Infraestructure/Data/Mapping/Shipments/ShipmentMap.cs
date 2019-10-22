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
                // shipment                                
            });
        }
    }
}
