using System;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using System.Net;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;
using StormyCommerce.Core.Models.Dtos.GatewayRequests;
using StormyCommerce.Module.Orders.Interfaces;
using StormyCommerce.Module.Orders.Area.Models;
using static StormyCommerce.Module.Orders.Services.CalcPrecoPrazoWSSoapClient;
using StormyCommerce.Api.Framework.Ioc;
using StormyCommerce.Module.Orders.Area.Models.Correios;
using System.Linq;
using System.Collections.Generic;
using StormyCommerce.Core.Shipment;
using StormyCommerce.Core.Models.Shipment.Response;
using StormyCommerce.Module.Orders.Extensions;
using StormyCommerce.Core.Models.Shipment.Request;
using StormyCommerce.Core.Entities.Shipping;

namespace StormyCommerce.Module.Orders.Services
{
    //TODO:What to return in GetShippmentOptionsAsync?
    public class CorreiosService : IShippingProvider
    {        
        private readonly ICalcPrecoPrazoWSSoap _correiosSoapWs;        
        public CorreiosService(ICalcPrecoPrazoWSSoap correiosSoapWs)
        {            
            _correiosSoapWs = correiosSoapWs;
        }                
        public async Task<DeliveryCalculationResponse> CalculateDeliveryPriceAndTime(CalcPrecoPrazoModel model)
        {                        
            var response = await _correiosSoapWs.CalcPrecoPrazoAsync(Container.Configuration["Correios:CodigoEmpresa"],                
                Container.Configuration["Correios:Senha"],                
                model.nCdServico,
                Container.Configuration["Correios:OriginPostalCode"],
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
            return new DeliveryCalculationResponse
            {
                Options = new List<DeliveryCalculationOptionResponse>(response.Servicos.Select(s => s.MapToDeliveryCalculationResponse()))
            }; 
        }        
        
        public async Task<DeliveryCalculationResponse> DefaultDeliveryCalculation(StormyShipment shipment)
        {            
            var response = await CalculateDeliveryPriceAndTime(GetDefaultShippingCalcModel(shipment));
            return response;            
        }         
        public async Task<DeliveryCalculationResponse> CalculateDeliveryPriceAndTime(DeliveryCalculationRequest request)
        {
            var response = await _correiosSoapWs.CalcPrecoPrazoAsync(Container.Configuration["Correios:CodigoEmpresa"],
                Container.Configuration["Correios:Senha"],
                request.ShippingMethod,
                Container.Configuration["Correios:OriginPostalCode"],
                request.DestinationPostalCode,
                request.Weight.ToString(),
                (int)request.FormatCode,
                request.Length,
                request.Height,
                request.Width,
                request.Diameter,
                request.MaoPropria,
                request.ValorDeclarado,
                request.WarningOfReceiving);
            return new DeliveryCalculationResponse
            {
                Options = new List<DeliveryCalculationOptionResponse>(response.Servicos.Select(s => s.MapToDeliveryCalculationResponse()))
            };
        }
        private CalcPrecoPrazoModel GetDefaultShippingCalcModel(StormyShipment shipment)
        {                            
            return new CalcPrecoPrazoModel {             
                nCdEmpresa = Container.Configuration["Correios:CodigoEmpresa"],
                sDsSenha = Container.Configuration["Correios:Senha"],          
                sCepOrigem = Container.Configuration["Correios:OriginPostalCode"],
                nVlAltura = (decimal)shipment.TotalHeight,
                nVlLargura = (decimal)shipment.TotalWidth,         
                nVlComprimento = (decimal)shipment.TotalLength,
                nVlPeso = shipment.TotalWeight.ToString(),
                nVlDiametro = 0,
                nCdServico = ServiceCode.Sedex,                                                            
                nCdFormato = (int)FormatCode.CaixaOuPacote, 
                sCepDestino = shipment.DestinationAddress.PostalCode,
                sCdAvisoRecebimento = "N",
                sCdMaoPropria = "N",
                //TODO: this is the corrected value or the total?
                nVlValorDeclarado = shipment.Order.TotalPrice                       
            };
        }
    }
}
