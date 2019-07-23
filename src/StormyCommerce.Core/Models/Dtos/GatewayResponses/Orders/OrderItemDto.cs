﻿using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

namespace StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders
{
    public class OrderItemDto
    {
        public OrderItemDto(OrderItem orderItem)
        {
            ProductName = orderItem.ProductName;
            Price = orderItem.Product.Price;
            Quantity = orderItem.Quantity;
            Product = orderItem.Product.ToProductDto();
        }
        public string ProductName { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public ProductDto Product { get; private set; }
    }
}
