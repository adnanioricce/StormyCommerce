using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities;
using System;
using System.Collections.Generic;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Extensions;
using StormyCommerce.Core.Models;

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
        public StormyOrder Order { get; set; }        
        public string WhoReceives { get; set; }
        public string TrackNumber { get; set; }
        public string ShipmentMethod { get; set; }
        public string ShipmentServiceName { get; set; }
        public string ShipmentProvider { get; set; }
        public decimal TotalWeight { get; set; }
        public decimal TotalHeight { get; set; }
        public decimal TotalWidth { get; set; }
        public decimal TotalLength { get; set; }
        public decimal TotalArea { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ShippedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime ExpectedHourOfDay { get; set; }
        public string Comment { get; set; }
        public decimal DeliveryCost { get; set; }        
        public long BillingAddressId { get; set; }
        public CustomerAddress BillingAddress { get; set; }
        public long DestinationAddressId { get; set; }
        public CustomerAddress DestinationAddress { get; set; }        
        public ShippingStatus Status { get; set; }        
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Shipment CalculateShipmentMeasures(List<OrderItem> items)
        {
            Shipment shipment = new Shipment();                   
            items.ForEach(item => {
                var measure = new Measure(item);
                SetDimensions(measure,shipment);                
                item.Shipment = shipment;
                shipment.Items.Add(item);
            });
            return shipment;
        }
        public Shipment CalculateShipmentMeasures(List<OrderItemDto> items)
        {
            Shipment shipment = new Shipment();
            items.ForEach(item => {
                var measure = new Measure(item);       
                SetDimensions(measure,shipment);                                                     
            });
            return shipment;
        }        
        private void SetDimensions(Measure measure,Shipment shipment)
        {
            shipment.TotalArea += measure.Area; 
            shipment.TotalHeight += measure.Height; 
            shipment.TotalLength += measure.Length;
            shipment.TotalWeight += measure.Weight; 
            shipment.TotalWidth += measure.Width;
        }
        
    }
}
