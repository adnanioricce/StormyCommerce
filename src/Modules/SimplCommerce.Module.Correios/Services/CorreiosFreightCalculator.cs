using System;
using System.Threading.Tasks;
using SimplCommerce.Infrastructure.Data;
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
        public CorreiosFreightCalculator(CorreiosService correiosService,
            IRepository<Cart> cartRepository)
        {
            _correiosService = correiosService;
            _cartRepository = cartRepository;
        }
        public async Task<CalculateFreightResponse> CalculateFreightForItem(CalculateItemFreightRequest request)
        {
            throw new NotImplementedException();            
        }

        public Task<CalculateFreightResponse> CalculateFreightForPackage(CalculatePackageFreightRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
