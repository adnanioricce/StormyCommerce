using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using SimplCommerce.Module.Correios.Interfaces;
using static SimplCommerce.Module.Correios.Services.CalcPrecoPrazoWSSoapClient;
using SimplCommerce.Module.Correios.Models;
using SimplCommerce.Module.Correios.Models.Requests;
using SimplCommerce.Module.Correios.Models.Responses;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace SimplCommerce.Module.Correios.Services
{    
    public class CorreiosService 
    {        
        private readonly ICalcPrecoPrazoWSSoap _correiosSoapWs;        
        private readonly IConfiguration _configuration;
        public CorreiosService(ICalcPrecoPrazoWSSoap correiosSoapWs,IConfiguration configuration)
        {            
            _correiosSoapWs = correiosSoapWs;
            _configuration = configuration;
        }                
        public async Task<DeliveryCalculationResponse> CalculateDeliveryPriceAndTime(CalcPrecoPrazoModel model)
        {                        
            var response = await _correiosSoapWs.CalcPrecoPrazoAsync(_configuration["Correios:CodigoEmpresa"],                
                _configuration["Correios:Senha"],                
                model.nCdServico,
                _configuration["Correios:OriginPostalCode"],
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
                Options = new List<DeliveryCalculationOptionResponse>(response.Servicos.Select(s => new DeliveryCalculationOptionResponse(s)))
            }; 
        }                       
        public async Task<DeliveryCalculationResponse> CalculateDeliveryPriceAndTime(DeliveryCalculationRequest request)
        {
            var response = await _correiosSoapWs.CalcPrecoPrazoAsync(_configuration["Correios:CodigoEmpresa"],
                _configuration["Correios:Senha"],
                request.ServiceCode,
                _configuration["Correios:OriginPostalCode"],
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
                Options = new List<DeliveryCalculationOptionResponse>(response.Servicos.Select(s => new DeliveryCalculationOptionResponse(s)))
            };
        }        
    }
}
