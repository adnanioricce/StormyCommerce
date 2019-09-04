using System;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using Correios.Net;
namespace StormyCommerce.Module.Shipping.Services
{
    //TODO:What to return in GetShippmentOptionsAsync?
    public class CorreiosService : IShippingService
    {
        
        // public Task<List<ShipmentDto>> GetShippmentOptionsAsync(ShipmentDto shipment)
        // {
        //     throw new NotImplementedException();
        // }        
        public Task<Shipment> CalculateDeliveryPrice(string senderPostalCode,string destinationPostalCode)
        {
            throw new NotImplementedException();
        }
        public Task<Shipment> CreateShipmentTicketAsync(StormyOrder orderObject)
        {
            throw new NotImplementedException();
        }
        public Task CreateShipmentAsync(Shipment shipment)
        {
            throw new NotImplementedException();
        }         
        public Task CreateShipmentAsync(StormyOrder order)
        {
            throw new NotImplementedException();
        }         
    }
}
