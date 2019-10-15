﻿using System;
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

namespace StormyCommerce.Module.Orders.Services
{
    //TODO:What to return in GetShippmentOptionsAsync?
    public class CorreiosService 
    {
        private readonly IStormyRepository<Shipment> _shipmentRepository;        
        private readonly ICalcPrecoPrazoWSSoap _correiosSoapWs;        
        public CorreiosService(IStormyRepository<Shipment> shipmentRepository,
        ICalcPrecoPrazoWSSoap correiosSoapWs)
        {
            _shipmentRepository = shipmentRepository;            
            _correiosSoapWs = correiosSoapWs;
        }                
        public async Task<cResultado> CalculateDeliveryPriceAndTime(CalcPrecoPrazoModel model)
        {
            var soapClient = new CalcPrecoPrazoWSSoapClient(EndpointConfiguration.CalcPrecoPrazoWSSoap);            
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
            return response;
        }        
        public async Task<cResultado> DefaultDeliveryCalculation(Shipment shipment)
        {
            var soapClient = new CalcPrecoPrazoWSSoapClient(EndpointConfiguration.CalcPrecoPrazoWSSoap);
            var model = GetDefaultShippingCalcModel(shipment); 
            // return await _correiosSoapWs.CalcPrecoPrazoAsync();
            throw new NotImplementedException();
        }         
        private CalcPrecoPrazoModel GetDefaultShippingCalcModel(Shipment shipment){                            
            return new CalcPrecoPrazoModel {             
                    nCdEmpresa = Container.Configuration["Correios:CodigoEmpresa"],
                    sDsSenha = Container.Configuration["Correios:Senha"],          
                    sCepOrigem = Container.Configuration["Correios:OriginPostalCode"],
                    nVlAltura = shipment.TotalHeight,
                    nVlLargura = shipment.TotalWidth,                        
                    nVlDiametro = 0, 
                    nVlPeso = shipment.TotalWeight.ToString(),
                    nCdFormato = (int)FormatCode.CaixaOuPacote, 
                    sCepDestino = shipment.DestinationAddress.PostalCode,
                    sCdMaoPropria = "N",
                    //TODO: this is the corrected value or the total?
                    nVlValorDeclarado = shipment.Order.TotalPrice / 10                       
            };
        }
    }
}