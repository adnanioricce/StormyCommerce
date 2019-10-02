using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Shipping;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Shipping;
using StormyCommerce.Core.Models.Dtos.GatewayRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StormyCommerce.Module.PagarMe.Services
{
    public class ShippingService : IShippingService
    {
        private readonly IStormyRepository<Shipment> _shipmentRepository;
        private readonly IStormyRepository<StormyOrder> _orderRepository;
        private readonly HttpClient _httpClient;
        public ShippingService(IStormyRepository<Shipment> shipmentRepository,IStormyRepository<StormyOrder> orderRepository)
        {
            _shipmentRepository = shipmentRepository;
            _orderRepository = orderRepository;
            _orderRepository.Table.Include(o => o.Shipment);
        }
        public Shipment BuildShipmentForItems(List<ShipmentItem> shipmentItems)
        {
            Shipment shipment = new Shipment();
            shipmentItems.ForEach(s =>
            {
                shipment.TotalWeight += s.Quantity * s.UnitWeight;
                s.Shipment = shipment;
                shipment.Items.Add(s);
            });                        
            return shipment;
        }
        public async Task<Shipment> CalculateDeliveryPrice(ShipmentCalculationDto calculateShippingModel)
        {
            throw new NotImplementedException();
        }

        public async Task CreateShipmentAsync(Shipment shipment)
        {            
            await _shipmentRepository.AddAsync(BuildShipmentForItems(shipment.Items));
        }

        public async Task CreateShipmentAsync(StormyOrder order)
        {
            throw new NotImplementedException();            
        }
        public async Task<Shipment> GetShipmentById(long id)
        {
            return await _shipmentRepository.GetByIdAsync(id);
        }
        public async Task<Shipment> GetShipmentByOrderId(long orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            return order.Shipment;
        }
        public async Task<Shipment> GetShipmentByOrderId(Guid uniqueOrderId)
        {
            var order = await _orderRepository.Table.Include(o => o.Shipment).Where(o => o.OrderUniqueKey == uniqueOrderId).FirstOrDefaultAsync();
            return  order.Shipment;
        }
    }
}
