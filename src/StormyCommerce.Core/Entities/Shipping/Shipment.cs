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
        public double TotalWeight { get; set; }
        public double TotalHeight { get; set; }        
        public double TotalWidth { get; set; }
        public double TotalLength { get; set; }
        public double TotalArea { get; set; }
        public double CubeRoot { get; set; }
        public decimal SafeAmount { get; set; }
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
                shipment.TotalHeight = item.Product.Height;
                shipment.TotalWidth = item.Product.Width;
                shipment.TotalLength = item.Product.Length;
                shipment.TotalArea += item.Product.Width * item.Product.Height * item.Product.Length * item.Quantity;
                shipment.TotalWeight += item.Product.UnitWeight * item.Quantity;                                                                    
            });
            shipment.CubeRoot = Math.Ceiling(Math.Pow(shipment.TotalArea,(double)1/3));
            return shipment;
        }        
        
        
    }
}
