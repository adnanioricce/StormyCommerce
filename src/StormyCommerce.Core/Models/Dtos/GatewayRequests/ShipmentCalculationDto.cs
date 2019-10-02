namespace StormyCommerce.Core.Models.Dtos.GatewayRequests
{
    public class ShipmentCalculationDto
    {
        public string VendorCode { get; private set; }
        public string VendorPassword { get; private set; }        
        public string Weight { get; private set; }
        public decimal Height { get; private set; }
        public decimal Width { get; private set; }
        public decimal Diameter { get; private set; }
        public decimal Length { get; private set; }
        public int ShipmentFormat { get; private set; }
        public string OriginPostalCode { get; private set; }
        public string DestinationPostalCode { get; private set; }
        public string ShippingMethod { get; private set; }
        public string ShippingMethodCode { get; private set; }
        public decimal ValorDeclarado { get; private set; }
        public bool HasAvisoDeRecebimento { get; private set; }
        public bool HasMaoPropria { get; private set; }
    }
}
