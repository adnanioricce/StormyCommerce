using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Entities.Order;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities.Shipping
{    
    public class StormyShipment : EntityBase
    {
        public StormyShipment(long id)
        {
            Id = id;
        }
        public StormyShipment(){}                        
        public long StormyOrderId { get; set; }
        public virtual StormyOrder Order { get; set; }                
        public string TrackNumber { get; set; }
        public ShippingMethod ShipmentMethod { get; set; }        
        public string ShipmentProvider { get; set; }
        public double TotalWeight { get; set; }
        public double TotalHeight { get; set; }        
        public double TotalWidth { get; set; }
        public double TotalLength { get; set; }
        public double TotalArea { get; set; }
        public double CubeRoot { get; set; }
        public decimal SafeAmount { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset? ShippedDate { get; set; }
        public DateTimeOffset? DeliveryDate { get; set; }
        public DateTimeOffset? ExpectedDeliveryDate { get; set; }
        public DateTimeOffset? ExpectedHourOfDay { get; set; }        
        public decimal DeliveryCost { get; set; }                
        public long DestinationAddressId { get; set; }
        public virtual CustomerAddress DestinationAddress { get; set; }        
        public ShippingStatus Status { get; set; }        
        public virtual List<OrderItem> Items { get; set; } = new List<OrderItem>();                                
    }
}
