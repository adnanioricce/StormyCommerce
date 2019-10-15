using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Entities
{
    //! Is to little info, should this exist?
    //TODO:Is the reference to StormyCustomerId useful?Why not use only the UserId?
    //TODO:Define a property to know the "metrics" of a shipment object
    public class Shipment : BaseEntity
    {
        public Shipment(long id)
        {
            Id = id;
        }
        public Shipment(){}                        
        public long StormyOrderId { get; set; }
        public StormyOrder Order { get; set; }
        public string UserId { get; set; }
        public long StormyCustomerId { get; set; }
        public StormyCustomer Customer { get; set; }
        public string WhoReceives { get; set; }
        public string TrackNumber { get; set; }
        public string ShipmentMethod { get; set; }
        public string ShipmentProvider { get; set; }
        public decimal TotalWeight { get; set; }
        public int TotalHeight { get; set; }
        public int TotalWidth { get; set; }
        public int TotalArea { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Comment { get; set; }
        public decimal DeliveryCost { get; set; }        
        public long BillingAddressId { get; set; }
        public Address BillingAddress { get; set; }
        public long DestinationAddressId { get; set; }
        public Address DestinationAddress { get; set; }        
        public ShippingStatus Status { get; set; }        
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Shipment BuildShipment(List<OrderItem> items)
        {
            Shipment shipment = new Shipment();
            int totalArea = 0;            
            items.ForEach(item => {
                shipment.TotalHeight += item.Quantity * item.Product.Height;
                shipment.TotalWidth += item.Quantity * item.Product.Width;
                shipment.TotalWeight += item.Quantity * (decimal)item.Product.UnitWeight;
                shipment.TotalArea += item.Quantity * item.Product.CalculateDimensions();
                item.Shipment = shipment;
                shipment.Items.Add(item);
            });
            return shipment;
        }
    }
}
