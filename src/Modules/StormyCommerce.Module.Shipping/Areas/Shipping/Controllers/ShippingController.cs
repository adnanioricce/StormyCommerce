using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Interfaces.Domain.Shipping;

namespace StormyCommerce.Module.Shipping.Areas.Shipping.Controllers
{
    public class ShippingController : ControllerBase
    {
        private readonly IShippingService _shippingService;
        public ShippingController(IShippingService shippingService)
        {
            _shippingService = shippingService;
        }
        [HttpPost("calcdelivery")]
        [ValidateModel]
        public async Task CalculateDeliveryCost()
        {
            
        }
    }
}