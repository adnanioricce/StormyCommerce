namespace SimplCommerce.Module.Shipments.Models
{
    public class CalculateItemFreightRequest
    {
        public string ZipCode { get; set; }
        public int CartItemId { get; set; }        
    }
}
