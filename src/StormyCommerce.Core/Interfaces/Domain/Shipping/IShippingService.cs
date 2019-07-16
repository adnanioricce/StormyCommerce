namespace StormyCommerce.Core.Domain.Shipping
{
    public interface IShippingService
    {
        Task<object> GetShippmentOptionsAsync(object address);        
        Task<object> CalculateDeliveryPrice(object address);
        Task<object> CreateShipmentTicketAsync(object orderObject);        

    }
}