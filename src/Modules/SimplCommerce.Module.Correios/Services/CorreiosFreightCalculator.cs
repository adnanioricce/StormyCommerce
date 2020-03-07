using System;
using System.Linq;
using System.Threading.Tasks;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Correios.Interfaces;
using SimplCommerce.Module.Correios.Models;
using SimplCommerce.Module.Correios.Models.Requests;
using SimplCommerce.Module.Correios.Models.Responses;
using SimplCommerce.Module.Shipments.Models;
using SimplCommerce.Module.Shipments.Models.Requests;
using SimplCommerce.Module.Shipments.Models.Responses;
using SimplCommerce.Module.Shipments.Services;
using SimplCommerce.Module.ShoppingCart.Models;

namespace SimplCommerce.Module.Correios.Services
{
    public class CorreiosFreightCalculator : IFreightCalculator
    {
        private readonly CorreiosService _correiosService;
        private readonly IRepository<Cart> _cartRepository;
        private readonly IRepository<CartItem> _cartItemRepository;
        private readonly IPackageBuilder _packageBuilder;
        public CorreiosFreightCalculator(CorreiosService correiosService,
            IRepository<Cart> cartRepository,
            IRepository<CartItem> cartItemRepository,
            IPackageBuilder packageBuilder)
        {
            _correiosService = correiosService;
            _cartRepository = cartRepository;
            _cartItemRepository = cartItemRepository;
            _packageBuilder = packageBuilder;
        }
        public async Task<CalculateFreightResponse> CalculateFreightForItem(CalculateItemFreightRequest request)
        {
            throw new NotImplementedException();            
        }

        public async Task<CalculateFreightResponse> CalculateFreightForPackage(CalculatePackageFreightRequest request)
        {
            var cart = await _cartRepository.GetByIdAsync(request.CartId);
            var package = _packageBuilder.BuildPackage(cart.Items.Select(item => MapToPackageItem(item)).ToList());
            var priceAndTime = await _correiosService.CalculateDeliveryPriceAndTime(MapToDeliveryCalculationRequest(package,request));
            return MapToFreightResponse(priceAndTime);
            
        }       
        private CalculateFreightResponse MapToFreightResponse(DeliveryCalculationResponse response)
        {
            return new CalculateFreightResponse{
                Options = response.Options.Select(o => new CalculateFreightOptionResponse{
                    DeliveryDate = o.DeliveryDeadline,
                    Price = decimal.TryParse(o.Price,out var result) ? result : 0.0m,
                    ServiceName = o.Service
                }).ToList()
            };
        }    
        private DeliveryCalculationRequest MapToDeliveryCalculationRequest(Package package,CalculatePackageFreightRequest request)
        {
            return new DeliveryCalculationRequest
            {
                Height = (decimal)package.TotalHeight,
                Width = (decimal)package.TotalWidth,
                Length = (decimal)package.TotalLength,
                Weight = (decimal)package.TotalWeight,
                Diameter = (decimal)package.TotalDiameter,
                FormatCode = FormatCode.CaixaOuPacote,
                DestinationPostalCode = request.DestinationZipCode,
                MaoPropria = "N",
                WarningOfReceiving = "N",
                ValorDeclarado = package.Price,
                ServiceCode = request.ShippingMethod,
            };
        }             
        private PackageItem MapToPackageItem(CartItem item)
        {
            return new PackageItem{
                Height = item.Product.Height,
                Width = item.Product.Width,
                Length = item.Product.Length,
                Diameter = item.Product.Diameter,
                UnitWeight = item.Product.UnitWeight,
                Quantity = item.Quantity
                };
        }

    }
}
