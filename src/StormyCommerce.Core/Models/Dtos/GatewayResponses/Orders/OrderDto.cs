using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders
{
    //?Ask yourself:This will be the same to create and Read?
    public class OrderDto
    {
        public OrderDto(StormyOrder order)
        {
            Id = order.Id;
            OrderUniqueKey = order.OrderUniqueKey;            
            Comment = order.Comment;                
            TotalPrice = order.TotalPrice;
            Discount = order.Discount;
            OrderDate = order.OrderDate;            
            PaymentDate = order.PaymentDate;
            Status = order.Status;
            IsCancelled = IsCancelled;
            this.Items = order.Items.Select(p => p.ToOrderItemDto()).ToList();
            this.Payment = order.Payment == null ? this.Payment : new PaymentDto(order.Payment);
            this.Shipment = order.Shipment == null ? this.Shipment : new ShipmentDto(order.Shipment);            
        }
        public long Id { get; private set; }
        public Guid OrderUniqueKey { get; private set; }                       
        public string Comment { get; private set; }        
        public decimal Discount { get; private set; }                
        public decimal TotalPrice { get; private set; }
        public decimal DeliveryCost { get; private set; }        
        public DateTime OrderDate { get; private set; }        
        public DateTime? PaymentDate { get; private set; }
        public PaymentDto Payment { get; private set; } = new PaymentDto();
        public IList<OrderItemDto> Items { get; private set; } = new List<OrderItemDto>();
        public ShipmentDto Shipment { get; private set; } = new ShipmentDto();
        public OrderStatus Status { get; private set; }        
        public bool IsCancelled { get; private set; }
    }
}
