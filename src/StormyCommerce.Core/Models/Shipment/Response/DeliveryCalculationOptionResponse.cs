using System;
namespace StormyCommerce.Core.Models.Shipment.Response
{
    public class DeliveryCalculationOptionResponse
    {
        public DeliveryCalculationOptionResponse(){           }
        public DateTimeOffset DeliveryDeadline { get; set; }
        public DateTimeOffset? DeliveryMaxDate { get; set; }
        public DateTimeOffset? HourOfDay { get; set; }
        public string Price { get; set; }
        public string Service { get; set; }        
    }
}
