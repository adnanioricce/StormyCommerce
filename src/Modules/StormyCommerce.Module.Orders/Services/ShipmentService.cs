using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Api.Framework.Ioc;
using System;
using System.Linq;
using System.Threading.Tasks;

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
            _orderRepository.Table.Include(o => o.Shipment);
            _correiosService = correiosService;
        }
        public Shipment BuildShipmentForOrder(StormyOrder order)
        {            
            var shipment = new Shipment().BuildShipment(order.Items);
            shipment.DeliveryCost = order.DeliveryCost; 
            shipment.ShipmentProvider = "Correios";
            shipment.ShipmentMethod = order.ShippingMethod;
            shipment.DestinationAddress = order.ShippingAddress;             
            shipment.BillingAddress = Container.OriginAddress;
            shipment.WhoReceives = order.WhoReceives;
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
            
            throw new NotImplementedException();            
        }
        public async Task<Shipment> GetShipmentById(long id)
        {
            return await _shipmentRepository.GetByIdAsync(id);
        }
        public async Task<Shipment> GetShipmentByOrderIdAsync(long orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            return order.Shipment;
        }
        public async Task<Shipment> GetShipmentByOrderIdAsync(Guid uniqueOrderId)
        {
            var order = await _orderRepository.Table.Where(o => o.OrderUniqueKey == uniqueOrderId).FirstOrDefaultAsync();
            return  order.Shipment;
        }        
    }
}