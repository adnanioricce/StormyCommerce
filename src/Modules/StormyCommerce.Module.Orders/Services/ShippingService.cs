using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using System;
using System.Threading.Tasks;
using StormyCommerce.Core.Shipment;
using StormyCommerce.Core.Models.Shipment.Request;
using StormyCommerce.Core.Models.Shipment.Response;
using StormyCommerce.Core.Models.Shipment;
using StormyCommerce.Api.Framework.Ioc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using StormyCommerce.Core.Entities.Order;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace StormyCommerce.Module.Orders.Services
{
    public class ShippingService : IShippingService
    {        
        private readonly IShippingProvider _correiosService;
        private readonly IShippingBuilder _shippingBuilder;
        private readonly IStormyRepository<StormyShipment> _shipmentRepository;
        public ShippingService(IShippingBuilder shippingBuilder,
        IShippingProvider correiosService,
        IStormyRepository<StormyShipment> shipmentRepository
        )
        {
            _shippingBuilder = shippingBuilder;
            _correiosService = correiosService;
            _shipmentRepository = shipmentRepository;
        }

        public async Task<Result> CreateShipmentAsync(StormyShipment shipment)
        {
            try
            {
                await _shipmentRepository.AddAsync(shipment);
                return Result.Ok($"Shipment stored with success at {DateTimeOffset.UtcNow} for order ${shipment.Order.OrderUniqueKey}, created by user ${shipment.Order.Customer}");
            }catch(DbUpdateException exception)
            {
                return BuildErrorMessage(exception);
            }
        }

        public async Task<StormyShipment> PrepareShipment(PrepareShipmentRequest request)
        {
            var measures = _shippingBuilder.CalculateShippingMeasures(new CalculateShippingMeasuresModel(request.Order.Items));
            var shippingCalculation = await _correiosService.CalculateDeliveryPriceAndTime(new DeliveryCalculationRequest
            {
                Height = (decimal)measures.TotalHeight,
                Width = (decimal)measures.TotalWidth,
                Length = (decimal)measures.TotalLength,
                Weight = (decimal)measures.TotalWeight,
                Diameter = (decimal)measures.TotalDiameter,
                FormatCode = FormatCode.CaixaOuPacote,
                DestinationPostalCode = request.DestinationPostalCode,
                MaoPropria = "N",
                WarningOfReceiving = "N",
                ValorDeclarado = request.TotalPrice,
                ShippingMethod = request.ShippingMethod,
            });
            var shippingOption = new DeliveryCalculationOptionResponse();            
            shippingOption = shippingCalculation.Options.OrderBy(o => o.Price).FirstOrDefault();                                        
            var shipment = new StormyShipment
            {
                TotalArea = measures.CubeRoot,
                TotalHeight = measures.TotalHeight,
                TotalWidth = measures.TotalWidth,
                TotalLength = measures.TotalLength,
                TotalWeight = measures.TotalWeight,
                CubeRoot = measures.CubeRoot,
                Status = ShippingStatus.NotShippedYet,
                DeliveryCost = measures.DeliveryCost,
                DeliveryDate = shippingOption.DeliveryDate,
                ExpectedDeliveryDate = shippingOption.DeliveryMaxDate,
                ExpectedHourOfDay = shippingOption.HourOfDay,
                ShipmentMethod = (ShippingMethod)(Convert.ToInt32(shippingOption.Service)),
                SafeAmount = request.TotalPrice / 100,
                ShipmentProvider = "Correios",    
                StormyOrderId = request.Order.Id
                //TODO:Add Destination address Fetch
                
            };            
            shipment.Items = measures.Items.Select(i => new OrderItem
            {
                Id = i.Id,
                Price = i.Price,
                StormyProductId = i.Product.Id,
                StormyOrderId = request.Order.Id,
                Shipment = shipment,                
                Quantity = i.Quantity,                                
            }).ToList();                                  
            return shipment;
            
        }
        private Result BuildErrorMessage(DbUpdateException exception)
        {
            return Result.Fail($"Can't store shipment because Repository Throw a DbUpdateException in class {this.GetType().Name} on method {nameof(this.GetShippingMethod)} at time {DateTimeOffset.UtcNow}. \n Message:{exception.Message} \n Source:{exception.Source} \n StackTrace:{exception.StackTrace} \n, Data:{exception.Data} \n");
        }
        private string GetShippingMethod(string serviceCode)
        {
            switch (serviceCode)
            {
                case ServiceCode.PacAVista:
                    return ServiceCode.PacAVista;
                case ServiceCode.Sedex: 
                    return ServiceCode.Sedex; 
                case ServiceCode.Sedex10:
                    return ServiceCode.Sedex10;
                case ServiceCode.Sedex12:
                    return ServiceCode.Sedex12;
                case ServiceCode.SedexACobrar:
                    return ServiceCode.SedexACobrar;
                case ServiceCode.SedexHoje:
                    return ServiceCode.SedexHoje;
                default:
                    return serviceCode;
            }            

        }        

        
    }
}
