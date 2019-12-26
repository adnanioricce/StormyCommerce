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
    public class StormyOrder : EntityBase
    {
        public StormyOrder(long id)
        {
            Id = id;
        }

        public StormyOrder(long id, OrderDto orderDto) : this(id)
        {            
            Comment = orderDto.Comment;            
            Discount = orderDto.Discount;
            IsCancelled = orderDto.IsCancelled;
            Items = orderDto.Items.Select(item => item.ToOrderItem()).ToList();
            OrderUniqueKey = orderDto.OrderUniqueKey;                                                
            Status = orderDto.Status;
            OrderDate = orderDto.OrderDate;
        }
        public StormyOrder(){}
        public Guid OrderUniqueKey { get; set; }
        public string StormyCustomerId { get; set; }        
        public long PaymentId { get; set; }
        public long? ShipmentId { get; set; }
        public bool PickUpInStore { get; set; }
        public bool IsCancelled { get; set; } = false;                 
        public string Note { get; set; }
        public string Comment { get; set; }
        public decimal Discount { get; set; }          
        public decimal TotalPrice { get; set; }        
        public virtual StormyPayment Payment { get; set; }
        public virtual StormyCustomer Customer { get; set; }        
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }        
        public DateTime? PaymentDate { get; set; }
        public virtual List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public virtual Shipping.StormyShipment Shipment { get; set; }
        public OrderStatus Status { get; set; }        

        public OrderDto ToOrderDto()
        {
            return new OrderDto(this);
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void SyncStock(OrderStatus status)
        {
            if(status == OrderStatus.New){
                this.Items.ForEach(o => {
                    o.Product.UnitsInStock -= o.Quantity; 
                    o.Product.UnitsOnOrder += o.Quantity;
                });
            }
            if(status == OrderStatus.Canceled){
                this.Items.ForEach(o => {
                    o.Product.UnitsInStock += o.Quantity; 
                    o.Product.UnitsOnOrder -= o.Quantity;
                });
            }
        }
    }
}
