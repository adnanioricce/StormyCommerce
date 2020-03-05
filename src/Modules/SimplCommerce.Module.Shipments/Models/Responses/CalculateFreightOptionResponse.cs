using System;

namespace SimplCommerce.Module.Shipments.Models.Responses
{
    public class CalculateFreightOptionResponse
    {
        public DateTimeOffset DeliveryDate { get; set; }
        public decimal Price { get; set; }
    }
}
