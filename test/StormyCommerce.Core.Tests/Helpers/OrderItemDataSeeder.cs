using StormyCommerce.Core.Entities.Order;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Tests.Helpers
{
    public static class OrderItemDataSeeder
    {
        public static OrderItem GetOrderItemData()
        {
            return new OrderItem(new Random().Next())
            {
                Product = ProductDataSeeder.GetSampleData(),
                Quantity = 2,
                IsDeleted = false,
                StormyOrderId = 1,
                StormyProductId = 1,
                Order = new Entities.StormyOrder(1),
                LastModified = DateTimeOffset.UtcNow
            };
        }

        public static List<OrderItem> GetOrderItemListData()
        {
            return new List<OrderItem>
            {
               GetOrderItemData()
            };
        }
    }
}
