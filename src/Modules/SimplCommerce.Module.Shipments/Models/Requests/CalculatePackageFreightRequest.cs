namespace SimplCommerce.Module.Shipments.Models.Requests
{
    public class CalculatePackageFreightRequest
    {
        public string DestinationZipCode { get; set; }
        public int CartId { get; set; }
        public string ShippingMethod { get; set; }        
    }
}
