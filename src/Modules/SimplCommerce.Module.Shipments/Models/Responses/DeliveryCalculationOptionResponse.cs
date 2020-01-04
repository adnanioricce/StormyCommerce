using System;
namespace StormyCommerce.Core.Models.Shipment.Responses
{
    public class DeliveryCalculationOptionResponse
    {
        public DeliveryCalculationOptionResponse(){}
        public DateTimeOffset DeliveryDate { get; set; }
        public DateTimeOffset? DeliveryMaxDate { get; set; }
        public DateTimeOffset? HourOfDay { get; set; }
        public decimal Price { get; set; }
        public string Service { get; set; }        
    }
}
