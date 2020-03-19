﻿using Microsoft.Extensions.Configuration;
using SimplCommerce.Module.Correios.Interfaces;
using SimplCommerce.Module.Correios.Models;
using SimplCommerce.Module.Correios.Models.Requests;
using SimplCommerce.Module.Correios.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SimplCommerce.Module.Correios.Tests.Services
{
    public class CorreiosServiceTests
    {
        private readonly CorreiosService _service;
        public CorreiosServiceTests(CorreiosService service)
        {
            _service = service;
        }                

        [Fact]
        public async Task CalculateDeliveryPriceAndTime_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var model = new CalcPrecoPrazoModel{
                nCdEmpresa = "",
                sDsSenha = "",
                nCdServico = ServiceCode.Sedex,
                sCepOrigem = "19190970",
                sCepDestino = "19570970",
                nVlPeso = "1",
                nCdFormato = (int)FormatCode.CaixaOuPacote,
                nVlComprimento = 15,
                nVlAltura = 10,
                nVlLargura = 10,
                nVlDiametro = 0,
                sCdMaoPropria = "N",
                nVlValorDeclarado = 10.0m,
                sCdAvisoRecebimento = "N"
            };        

            // Act
            var result = await _service.CalculateDeliveryPriceAndTime(model);

            // Assert
            Assert.True(result.Options.Count >= 1);           
        }

        [Fact]
        public async Task CalculateDeliveryPriceAndTime_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange            
            DeliveryCalculationRequest request = new DeliveryCalculationRequest
            {
                ServiceCode = ServiceCode.Sedex,
                DestinationPostalCode = "08559300",
                Diameter = 1,
                Height = 3,
                Width = 16,
                Length = 16,
                WarningOfReceiving = "N",
                Weight = 3.5m,
                FormatCode = FormatCode.CaixaOuPacote,
                MaoPropria = "N",
                OriginPostalCode = "71020-056",
            };

            // Act
            var result = await _service.CalculateDeliveryPriceAndTime(request);

            // Assert
            Assert.True(result.Options.Count >= 1);            
        }
    }
}
