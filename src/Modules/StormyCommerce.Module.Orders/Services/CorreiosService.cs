using System;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using System.Net;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;
using StormyCommerce.Core.Models.Dtos.GatewayRequests;
using StormyCommerce.Module.Orders.Interfaces;
using StormyCommerce.Module.Orders.Area.Models;
using static StormyCommerce.Module.Orders.Services.CalcPrecoPrazoWSSoapClient;

namespace StormyCommerce.Module.Orders.Services
{
    //TODO:What to return in GetShippmentOptionsAsync?
    public class CorreiosService 
    {
        private readonly IStormyRepository<Shipment> _shipmentRepository;
        private readonly HttpClient _httpClient;
        private readonly ICalcPrecoPrazoWSSoap _correiosSoapWs;
        public CorreiosService(IStormyRepository<Shipment> shipmentRepository,HttpClient httpClient,ICalcPrecoPrazoWSSoap correiosSoapWs)
        {
            _shipmentRepository = shipmentRepository;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("http://ws.correios.com.br/calculador/CalcPrecoPrazo.asmx?wsdl");
            _correiosSoapWs = correiosSoapWs;
        }                
        public async Task<cResultado> CalculateDeliveryPriceAndTime(CalculateShippingModel model)
        {
            var soapClient = new CalcPrecoPrazoWSSoapClient(EndpointConfiguration.CalcPrecoPrazoWSSoap);
            var response = await _correiosSoapWs.CalcPrecoPrazoAsync(model.nCdEmpresa,
                model.sDsSenha,
                model.nCdServico,
                model.sCepOrigem,
                model.sCepDestino,
                model.nVlPeso,
                model.nCdFormato,
                model.nVlComprimento,
                model.nVlAltura,
                model.nVlLargura,
                model.nVlDiametro,
                model.sCdMaoPropria,
                model.nVlValorDeclarado,
                model.sCdAvisoRecebimento);
            return response;
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
