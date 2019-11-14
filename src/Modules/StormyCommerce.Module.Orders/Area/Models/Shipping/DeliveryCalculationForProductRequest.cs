using System;

namespace StormyCommerce.Module.Orders.Area.Models.Shipping
{
    public class DeliveryCalculationForProductRequest
    {

        public long ProductId { get; set; }
        public int Quantity { get; set; }
        public string PostalCode { get; set; }
    }
}
