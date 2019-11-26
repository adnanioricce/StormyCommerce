using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Entities.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders
{
    //?Ask yourself:This will be the same to create and Read?
    public class OrderDto
    {
        public OrderDto(StormyOrder product)
        {
            OrderUniqueKey = product.OrderUniqueKey;            
            Comment = product.Comment;                
            TotalPrice = product.TotalPrice;            
            OrderDate = product.OrderDate;            
            PaymentDate = product.PaymentDate;
            Status = product.Status;
            IsCancelled = IsCancelled;
            product.Items.ToList().ForEach(p => Items.Add(p.ToOrderItemDto()));            
        }

        public Guid OrderUniqueKey { get; private set; }
        public string ShippingMethod { get; private set; }
        public string PaymentMethod { get; private set; }
        public string TrackNumber { get; private set; }
        public string Comment { get; private set; }
        public string WhoReceives { get; private set; }
        public decimal Discount { get; private set; }        
        public decimal TotalWeight { get; private set; }
        public decimal TotalPrice { get; private set; }
        public decimal DeliveryCost { get; private set; }                
        public CustomerAddressDto ShippingAddress { get; private set; }
        public DateTime OrderDate { get; private set; }
        public DateTime ShippedDate { get; private set; }
        public DateTime DeliveryDate { get; private set; }
        public DateTime? PaymentDate { get; private set; }
        public PaymentDto Payment { get; set; }
        public IList<OrderItemDto> Items { get; private set; } = new List<OrderItemDto>();
        public OrderStatus Status { get; private set; }        
        public bool IsCancelled { get; private set; }
    }
}
