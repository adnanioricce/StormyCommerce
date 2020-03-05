namespace SimplCommerce.Module.Shipments.Models.Requests
{
    public class CalculatePackageFreightRequest
    {
        public string ZipCode { get; set; }
        public int CartId { get; set; }
    }
}
