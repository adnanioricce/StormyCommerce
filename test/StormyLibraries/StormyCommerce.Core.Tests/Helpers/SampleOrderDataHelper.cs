namespace StormyCommerce.Core.Tests.Helpers
{
    public static class SampleOrderDataHelper
    {        
        public static StormyOrder GetOrderData(Guid orderUniqueKey)
        {
            return new StormyOrder{
                OrderUniqueKey = orderUniqueKey;
                CustomerId = 1, 
                Status = OrderStatus.New,
                PickUpInStore = false, 
                IsDeleted = false, 
                ShippingMethod = "Sedex",
                TrackNumber = Guid.NewGuid().ToString("N");
                Comment = "meramente demonstrativo",
                Discount = 0.00,
                Tax = 1.01,
                TotalWeight = 0.100,
                TotalPrice = 34.99,
                DeliveryCost = 24.99,
                Customer = new StormyCustomer 
                {
                    UserId = "TODO",
                    CustomerAddresses = new List<CustomerAddress>{
                        new CustomerAddress{

                        }
                    },
                    DefaultShippingAddress = new CustomerAddress{

                    },
                    IsDeleted = false,
                    Fullname = "Aguinobaldo de Arimateia",
                    Username = "usernamequalquer",
                    Email = "aguinaldo@sieu.com",                    
                },
                ShippingAddress = new CustomerAddress{

                },
                //TODO:OrderDate,RequiredDate,ShippedDate,DeliveryDate,PaymentDate,Items,Shipments,Status,ShippingStatus
            };
        }
        public static StormyOrder GetOrderData()
        {
            return new StormyOrder{
                
            };
        }
    }
}