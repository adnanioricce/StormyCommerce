namespace SimplCommerce.Module.Shipments.Models.Requests
{
    public class CalculatePackageFreightRequest
    {
        public string DestinationZipCode { get; set; }
        public long CartId { get; set; }
        public string ShippingMethod { get; set; }        
    }
}
