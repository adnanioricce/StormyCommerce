using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Api.Framework.Ioc;
using System;
using System.Linq;
using System.Threading.Tasks;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models;
using StormyCommerce.Module.Orders.Area.Models.Correios;

namespace StormyCommerce.Module.Orders.Services
{
    public class ShippingService : IShippingService
    {
        private readonly IStormyRepository<Shipment> _shipmentRepository;
        private readonly IStormyRepository<StormyOrder> _orderRepository;        
        private readonly CorreiosService _correiosService;
        public ShippingService(IStormyRepository<Shipment> shipmentRepository,
        IStormyRepository<StormyOrder> orderRepository,
        CorreiosService correiosService
        )
        {
            _shipmentRepository = shipmentRepository;
            _orderRepository = orderRepository;            
            _correiosService = correiosService;
        }
        public Shipment CalculateShipmentDimensions(StormyOrder order)
        {            
            var shipment = new Shipment().CalculateShipmentMeasures(order.Items);            
            shipment.ShipmentProvider = "Correios";                        
            shipment.BillingAddress = Container.OriginAddress;            
            shipment.Status = ShippingStatus.NotShippedYet;             
            shipment.Order = order;                            
           
            return shipment;
        }            
        public async Task CreateShipmentAsync(Shipment shipment)
        {        
            await _shipmentRepository.AddAsync(shipment);
        }

        public async Task CreateShipmentAsync(StormyOrder order)
        {            
            var shipment = CalculateShipmentDimensions(order);
            if(!order.PickUpInStore){
                var calcResult = await _correiosService.DefaultDeliveryCalculation(shipment);                
                var shippingOption = calcResult.Options.FirstOrDefault();
                shipment.ExpectedDeliveryDate = shippingOption.DeliveryDeadline; 
                shipment.ExpectedHourOfDay = shippingOption.HourOfDay; 
                shipment.DeliveryDate = shippingOption.DeliveryMaxDate;
                shipment.ShipmentMethod = GetShippingMethod(shippingOption.Service);
                shipment.DeliveryCost = Price.GetPriceFromString(shippingOption.Price).GetPriceValueInDecimal();
                order.Shipment = shipment;                
            }
            await CreateShipmentAsync(shipment);
        }
        public async Task<Shipment> GetShipmentById(long id)
        {
            _orderRepository.Table.Include(o => o.Shipment);
            return await _shipmentRepository.GetByIdAsync(id);
        }
        public async Task<Shipment> GetShipmentByOrderIdAsync(long orderId)
        {
            var shipment = await _shipmentRepository.Table.Include(o => o.Order).Where(o => o.StormyOrderId == orderId).FirstOrDefaultAsync();
            return shipment;
        }
        public async Task<Shipment> GetShipmentByOrderIdAsync(Guid uniqueOrderId)
        {
            var order = await _orderRepository.Table.Where(o => o.OrderUniqueKey == uniqueOrderId).FirstOrDefaultAsync();
            return  order.Shipment;
        }      
        public async Task<Shipment> CalculateDeliveryCost(Shipment shipment,string serviceCode)
        {            
            var calcResult = await _correiosService.DefaultDeliveryCalculation(shipment);                
            var shippingOption = calcResult.Options.FirstOrDefault(s => s.Service.Equals(serviceCode));
            shipment.ExpectedDeliveryDate = shippingOption.DeliveryDeadline; 
            shipment.ExpectedHourOfDay = shippingOption.HourOfDay; 
            shipment.DeliveryDate = shippingOption.DeliveryMaxDate;
            shipment.ShipmentMethod = GetShippingMethod(shippingOption.Service);
            shipment.DeliveryCost = Price.GetPriceFromString(shippingOption.Price).GetPriceValueInDecimal();            
            return shipment;       
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
