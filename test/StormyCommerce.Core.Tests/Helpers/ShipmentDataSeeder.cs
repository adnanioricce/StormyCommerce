﻿using StormyCommerce.Core.Entities;
using System;
using System.Collections.Generic;

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
            return new Shipment(2)
            {
                TrackNumber = sampleTrackNumber,
                Comment = "a single comment",                
                DeliveryDate = DateTime.Today.AddDays(3),
                ShippedDate = DateTime.Today.AddDays(-1),
                DeliveryCost = 20.99m,
                TotalWeight = 0.400,
                LastModified = DateTime.UtcNow,
                CreatedOn = DateTime.UtcNow,
                IsDeleted = false
            };
        }
    }
}
