using StormyCommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StormyCommerce.Core.Tests.Helpers
{
    public static class ShipmentDataSeeder
    {
        private static readonly string sampleTrackNumber = "D78F02B4-A0F4-4D1E-BF27-26490C5FE087";
        public static List<Shipment> GetShipmentSeeders()
        {
            return new List<Shipment>
            {
                GetShipmentSeed()
            };
        }
        public static Shipment GetShipmentSeed()
        {
            return new Shipment
            {
                TrackNumber = sampleTrackNumber,
                Comment = "a single comment",
                DeliveryCost = 22.29m,
                DeliveryDate = DateTime.Today.AddDays(3),
                ShippedDate = DateTime.Today.AddDays(-1),
                Price = 20.99m,
                TotalWeight = 0.400m,
                LastModified = DateTime.UtcNow,
                CreatedOn = DateTime.UtcNow,
                IsDeleted = false
            };
        }
    }
}
