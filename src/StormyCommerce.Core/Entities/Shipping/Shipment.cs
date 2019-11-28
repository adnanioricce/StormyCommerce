using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Entities.Order;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities
{    
    public class Shipment : BaseEntity
    {
        public Shipment(long id)
        {
            Id = id;
        }
        public Shipment(){}                        
        public long StormyOrderId { get; set; }
        public virtual StormyOrder Order { get; set; }        
        public string WhoReceives { get; set; }
        public string TrackNumber { get; set; }
        public string ShipmentMethod { get; set; }
        public string ShipmentServiceName { get; set; }
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
        public string Comment { get; set; }
        public decimal DeliveryCost { get; set; }        
        public long BillingAddressId { get; set; }
        public virtual CustomerAddress BillingAddress { get; set; }
        public long DestinationAddressId { get; set; }
        public virtual CustomerAddress DestinationAddress { get; set; }        
        public ShippingStatus Status { get; set; }        
        public virtual List<OrderItem> Items { get; set; } = new List<OrderItem>();                
        public void SetShipmentMeasures()
        {

        }
        
    }
}
