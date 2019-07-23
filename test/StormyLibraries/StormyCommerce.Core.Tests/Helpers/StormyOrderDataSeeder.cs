using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Order;
using System;
using System.Collections.Generic;

namespace StormyCommerce.Core.Tests.Helpers
{
    public static class StormyOrderDataSeeder
    {        
        public static StormyOrder GetOrderData(Guid orderUniqueKey)
        {
            return new StormyOrder{
                OrderUniqueKey = orderUniqueKey,
                CustomerId = 1, 
                Status = OrderStatus.New,
                PickUpInStore = false, 
                IsDeleted = false, 
                ShippingMethod = "Sedex",
                TrackNumber = Guid.NewGuid().ToString("N"),
                Comment = "meramente demonstrativo",
                Discount = 0.00m,
                Tax = 1.01m,
                TotalWeight = 0.100m,
                TotalPrice = 34.99m,
                DeliveryCost = 24.99m,
                Customer = new StormyCustomer 
                {
                    UserId = "TODO",                    
                    DefaultShippingAddress = CustomerAddressSeeder.GetCustomerAddressData(),
                    IsDeleted = false,
                    FullName = "Aguinobaldo de Arimateia",
                    Username = "usernamequalquer",
                    Email = "aguinaldo@sieu.com",                    
                },
                ShippingAddress = CustomerAddressSeeder.GetCustomerAddressData(),
                OrderDate = DateTime.Today,
                DeliveryDate = DateTime.Today.AddDays(7),
                PaymentDate = DateTime.Today.AddDays(3),
                Items = OrderItemDataSeeder.GetOrderItemListData(),                
                PaymentId = 1,               
                Shipments = ShipmentDataSeeder.GetShipmentSeeders(),
                RequiredDate = DateTime.Today.AddDays(14),
                LastModified = DateTime.UtcNow,
                Note = "a simple note",
                ShippedDate = DateTime.Today,
                ShippingStatus = Entities.Shipping.ShippingStatus.Shipped                               
            };
        }
        public static StormyOrder GetOrderEditData(Guid orderUniqueKey)
        {
            return new StormyOrder
            {                
                OrderUniqueKey = orderUniqueKey,
                CustomerId = 1,
                Status = OrderStatus.New,
                PickUpInStore = false,
                IsDeleted = false,
                ShippingMethod = "Sedex",
                TrackNumber = Guid.NewGuid().ToString("N"),
                Comment = "updated comment",
                Discount = 0.00m,
                Tax = 1.00m,
                TotalWeight = 0.100m,
                TotalPrice = 24.99m,
                DeliveryCost = 14.99m,
                Customer = new StormyCustomer
                {
                    UserId = "TODO",
                    DefaultShippingAddress = CustomerAddressSeeder.GetCustomerAddressData(),
                    IsDeleted = false,
                    FullName = "Aguinobaldo de Arimateia",
                    Username = "usernamequalquer",
                    Email = "aguinaldo@sieu.com",
                },
                ShippingAddress = CustomerAddressSeeder.GetCustomerAddressData(),
                OrderDate = DateTime.Today,
                DeliveryDate = DateTime.Today.AddDays(7),
                PaymentDate = DateTime.Today.AddDays(3),
                Items = OrderItemDataSeeder.GetOrderItemListData(),
                PaymentId = 1,
                Shipments = ShipmentDataSeeder.GetShipmentSeeders(),
                RequiredDate = DateTime.Today.AddDays(14),
                LastModified = DateTime.UtcNow,
                Note = "a simple note",
                ShippedDate = DateTime.Today,
                ShippingStatus = Entities.Shipping.ShippingStatus.Shipped
            };
        }
    }
}
