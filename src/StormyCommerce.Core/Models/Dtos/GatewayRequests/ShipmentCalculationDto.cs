using System;

namespace StormyCommerce.Core.Models.Dtos.GatewayRequests
{
    public class ShipmentCalculationDto
    {
        public string Weight { get; private set; }
        public decimal Height { get; private set; }
        public decimal Width { get; private set; }
        public decimal Diameter { get; private set; }
        public decimal Length { get; private set; }        
        public string ShipmentFormat { get; private set; }        
        public string OriginPostalCode { get; private set; }
        public string DestinationPostalCode { get; private set; }

    }
}
