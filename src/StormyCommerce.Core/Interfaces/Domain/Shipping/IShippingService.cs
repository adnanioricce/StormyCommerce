using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Domain.Shipping
{
    //?Should I do this here or on the client?
    public interface IShippingService
    {
        Task<object> GetShippmentOptionsAsync(object address);        
        Task<object> CalculateDeliveryPrice(object address);
        Task<object> CreateShipmentTicketAsync(object orderObject);
        Task<object> CheckAddressAsync(object addressObject);
    }
}
