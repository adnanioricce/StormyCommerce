using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SimplCommerce.Module.Inventory.Models;
using SimplCommerce.Module.Orders.Models;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;

namespace SimplCommerce.Module.Shipments.Models
{
    public class Shipment : EntityBase
    {
        public Shipment()
        {
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
        }

        public long OrderId { get; set; }

        public Order Order { get; set; }

        [StringLength(450)]
        public string TrackingNumber { get; set; }
        public ShippingMethod ShipmentMethod { get; set; }
        public string ShipmentProvider { get; set; }
        public double TotalWeight { get; set; }
        public double TotalHeight { get; set; }
        public double TotalWidth { get; set; }
        public double TotalLength { get; set; }
        public double TotalArea { get; set; }
        public double CubeRoot { get; set; }
        public decimal SafeAmount { get; set; }

        public long WarehouseId { get; set; }

        public long? VendorId { get; set; }

        public Warehouse Warehouse { get; set; }

        public long CreatedById { get; set; }

        public User CreatedBy { get; set; }        

        public IList<ShipmentItem> Items { get; set; } = new List<ShipmentItem>();
        public DateTimeOffset? ShippedDate { get; set; }
        public DateTimeOffset? DeliveryDate { get; set; }
        public DateTimeOffset? ExpectedDeliveryDate { get; set; }
        public DateTimeOffset? ExpectedHourOfDay { get; set; }
        public decimal DeliveryCost { get; set; }
        public long DestinationAddressId { get; set; }
        public virtual CustomerAddress DestinationAddress { get; set; }
        public ShipmentStatus Status { get; set; }
    }
}
