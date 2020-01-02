using SimplCommerce.Module.Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Module.Orders.Models.Dtos
{    
    public class OrderDto
    {
        public OrderDto()
        {

        }
        public OrderDto(Order order)
        {
            Id = order.Id;
            OrderUniqueKey = order.OrderUniqueKey;            
            OrderNote = order.OrderNote;                
            OrderTotal = order.OrderTotal;
            DiscountAmount = order.DiscountAmount;
            CreatedOn = order.CreatedOn;            
            PaymentDate = order.PaymentDate;
            Status = order.OrderStatus;
            IsCancelled = IsCancelled;
            this.Items = order.OrderItems.Select(p => new OrderItemDto(p)).ToList();            
        }
        public long Id { get; private set; }
        public Guid OrderUniqueKey { get; private set; }                       
        public string OrderNote { get; private set; }        
        public decimal DiscountAmount { get; private set; }                
        public decimal OrderTotal { get; private set; }
        public decimal DeliveryCost { get; private set; }        
        public DateTimeOffset CreatedOn { get; private set; }        
        public DateTimeOffset PaymentDate { get; private set; }        
        public IList<OrderItemDto> Items { get; private set; } = new List<OrderItemDto>();        
        public OrderStatus Status { get; private set; }        
        public bool IsCancelled { get; private set; }
    }
}
