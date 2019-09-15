using System;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using Correios.Net;
using System.Net;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;
using StormyCommerce.Module.Shipping.Areas.Shipping.Models;
using StormyCommerce.Core.Models.Dtos.GatewayRequests;

namespace StormyCommerce.Module.Shipping.Services
{
    //TODO:What to return in GetShippmentOptionsAsync?
    public class CorreiosService : IShippingService
    {
        private readonly IStormyRepository<Shipment> _shipmentRepository;
        private readonly HttpClient _httpClient;
        public CorreiosService(IStormyRepository<Shipment> shipmentRepository,HttpClient httpClient)
        {
            _shipmentRepository = shipmentRepository;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://ws.correios.com.br/calculador/CalcPrecoPrazo.asmx?wsdl");
        }        
        public Task<Shipment> CalculateDeliveryPrice(ShipmentCalculationDto calculateShippingModel)
        {
            // Correios.Net.Address address = SearchZip.GetAddress(senderPostalCode);
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