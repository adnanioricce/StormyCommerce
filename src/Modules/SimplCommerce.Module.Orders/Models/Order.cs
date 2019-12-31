﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using StormyCommerce.Core.Entities;

namespace SimplCommerce.Module.Orders.Models
{
    public class Order : EntityBase
    {
        public Order()
        {
            CreatedOn = DateTimeOffset.Now;
            LatestUpdatedOn = DateTimeOffset.Now;
            OrderStatus = OrderStatus.New;
            IsMasterOrder = false;
        }

        public Guid OrderUniqueKey { get; set; }
        public long CustomerId { get; set; }

        [JsonIgnore] // To simplify the json stored in order history
        public User Customer { get; set; }       

        public long LatestUpdatedById { get; set; }

        [JsonIgnore]
        public User LatestUpdatedBy { get; set; }        

        public long CreatedById { get; set; }

        [JsonIgnore]
        public User CreatedBy { get; set; }

        public long? VendorId { get; set; }

        [StringLength(450)]
        public string CouponCode { get; set; }

        [StringLength(450)]
        public string CouponRuleName { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal SubTotal { get; set; }

        public decimal SubTotalWithDiscount { get; set; }

        public long ShippingAddressId { get; set; }

        public OrderAddress ShippingAddress { get; set; }

        public long BillingAddressId { get; set; }

        public OrderAddress BillingAddress { get; set; }

        public IList<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public OrderStatus OrderStatus { get; set; }

        [StringLength(1000)]
        public string OrderNote { get; set; }

        public long? ParentId { get; set; }

        [JsonIgnore]
        public Order Parent { get; set; }

        public bool IsMasterOrder { get; set; }
        public bool PickUpInStore { get; set; }

        [StringLength(450)]
        public string ShippingMethod { get; set; }

        public decimal ShippingFeeAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal OrderTotal { get; set; }

        [StringLength(450)]
        public string PaymentMethod { get; set; }

        public decimal PaymentFeeAmount { get; set; }

        public IList<Order> Children { get; protected set; } = new List<Order>();
        public DateTimeOffset PaymentDate { get; set; }
        public DateTimeOffset RequiredDate { get; set; }

        public void AddOrderItem(OrderItem item)
        {
            item.Order = this;
            OrderItems.Add(item);
        }        
    }
}
