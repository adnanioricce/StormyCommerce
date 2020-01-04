using StormyCommerce.Core.Interfaces;
using System;
using System.Threading.Tasks;
using StormyCommerce.Core.Shipment;
using StormyCommerce.Core.Models.Shipment.Responses;
using StormyCommerce.Core.Models.Shipment;
using System.Linq;
using StormyCommerce.Core.Models;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Module.Shipments.Models;
using SimplCommerce.Module.Shipments.Interfaces;
using SimplCommerce.Module.Shipments.Requests;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.Shipments.Models.Request;

namespace StormyCommerce.Module.Orders.Services
{
    //TODO: Move to SimplCommerce.Module.Shipment.Services
    public class ShippingService : IShippingService
    {        
        private readonly IShippingProvider _correiosService;
        private readonly IShippingBuilder _shippingBuilder;
        private readonly IStormyRepository<Shipment> _shipmentRepository;
        public ShippingService(IShippingBuilder shippingBuilder,
        IShippingProvider correiosService,
        IStormyRepository<Shipment> shipmentRepository
        )
        {
            _shippingBuilder = shippingBuilder;
            _correiosService = correiosService;
            _shipmentRepository = shipmentRepository;
        }

        public async Task<Result> CreateShipmentAsync(Shipment shipment)
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

        public async Task<Shipment> PrepareShipment(PrepareShipmentRequest request)
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
                ValorDeclarado = request.OrderTotal,
                ShipmentMethod = request.ShippingMethod,
            });
            var shippingOption = new DeliveryCalculationOptionResponse();            
            shippingOption = shippingCalculation.Options.OrderBy(o => o.Price).FirstOrDefault();                                        
            var shipment = new Shipment
            {
                TotalArea = measures.CubeRoot,
                TotalHeight = measures.TotalHeight,
                TotalWidth = measures.TotalWidth,
                TotalLength = measures.TotalLength,
                TotalWeight = measures.TotalWeight,
                CubeRoot = measures.CubeRoot,
                Status = ShipmentStatus.NotShippedYet,
                DeliveryCost = measures.DeliveryCost,
                DeliveryDate = shippingOption.DeliveryDate,
                ExpectedDeliveryDate = shippingOption.DeliveryMaxDate,
                ExpectedHourOfDay = shippingOption.HourOfDay,
                ShipmentMethod = (ShippingMethod)(Convert.ToInt32(shippingOption.Service)),
                SafeAmount = request.OrderTotal / 100,
                ShipmentProvider = "Correios",    
                OrderId = request.Order.Id
                //TODO:Add Destination address Fetch
                
            };            
            shipment.Items = measures.Items.Select(i => new ShipmentItem
            {                
                OrderItemId = i.Id,
                ShipmentId = shipment.Id,
                ProductId = i.Product.Id,                
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
