﻿using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders
{
    public class OrderItemDto
    {
        public OrderItemDto(OrderItem orderItem)
        {            
            Price = orderItem.Price;
            Quantity = orderItem.Quantity;
            Product = new ProductDto(orderItem.Product);
        }
        public OrderItemDto(string price,int quantity,ProductDto product)
        {
            Price = price;
            Quantity = quantity;
            Product = product;
        }
        
        public string Price { get; private set; }
        public int Quantity { get; private set; }
        public ProductDto Product { get; private set; }        

        public OrderItem ToOrderItem()
        {
            return new OrderItem
            {                
                Quantity = this.Quantity,
                Product = this.Product.ToStormyProduct(),
                Price = this.Price
            };
        }
    }
}
