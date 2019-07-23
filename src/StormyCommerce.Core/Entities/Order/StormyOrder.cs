﻿using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Entities
{
	public class StormyOrder : BaseEntity
	{        
        public Guid OrderUniqueKey { get; set; }
        public long CustomerId { get; set;}                
        public long PaymentId { get; set; }                        
        public bool PickUpInStore { get; set; }        
        public string ShippingMethod { get; set; }
        public string PaymentMethod { get; set; }
        public string TrackNumber { get; set; }
        public string Note { get; set; }
        public string Comment { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalWeight { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DeliveryCost { get; set; }
        public Payment Payment { get; set; }
        public StormyCustomer Customer { get; set; }
        public CustomerAddress ShippingAddress { get; set; }                
        public DateTime OrderDate {get;set; }
		public DateTime RequiredDate {get;set; }
		public DateTime ShippedDate {get;set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public IList<OrderItem> Items { get; set; } = new List<OrderItem>();
        public IList<Shipment> Shipments { get; set; } = new List<Shipment>();
        public OrderStatus Status { get; set; }
        public ShippingStatus ShippingStatus { get; set; }               
        public OrderDto ToOrderDto()
        {
            return new OrderDto(this);
        }
        public void AddShipment(Shipment shipment)
        {
            Shipments.Add(shipment);
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
	}
}
