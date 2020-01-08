﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SimplCommerce.Module.Core.Extensions;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Orders.Areas.Orders.ViewModels;
using SimplCommerce.Module.Orders.Services;
using SimplCommerce.Module.ShoppingCart.Models;
using SimplCommerce.Module.ShoppingCart.Services;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;

namespace SimplCommerce.Module.Orders.Areas.Orders.Controllers
{
    [Area("ShoppingCart")]
    [Authorize(Roles = "admin")]
    public class CheckoutApiController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly ICartService _cartService;
        private readonly IWorkContext _workContext;
        private readonly IStormyRepository<Cart> _cartRepository;

        public CheckoutApiController(
            IOrderService orderService,
            ICartService cartService,
            IWorkContext workContext,
            IStormyRepository<Cart> cartRepository)
        {
            _orderService = orderService;
            _cartService = cartService;
            _workContext = workContext;
            _cartRepository = cartRepository;
        }

        [HttpPost("api/cart/{cartId}/update-tax-and-shipping-prices")]
        public async Task<IActionResult> UpdateTaxAndShippingPrices(long cartId, [FromBody] TaxAndShippingPriceRequestVm model)
        {
            var currentUser = await _workContext.GetCurrentUser();
            var cart = await _cartRepository.Query().FirstOrDefaultAsync(x => x.Id == cartId);
            if (cart == null)
            {
                return NotFound();
            }

            if (cart.CreatedById != currentUser.Id)
            {
                return Forbid();
            }

            var orderTaxAndShippingPrice = await _orderService.UpdateTaxAndShippingPrices(cart.Id, model);
            return Ok(orderTaxAndShippingPrice);
        }

        [HttpPost("api/cart/{cartId}/order")]
        public async Task<IActionResult> CreateOrder(long cartId, [FromBody] DeliveryInformationVm deliveryInformationVm)
        {
            var currentUser = await _workContext.GetCurrentUser();
            var cart = await _cartRepository.Query().FirstOrDefaultAsync(x => x.Id == cartId);
            if (cart == null)
            {
                return NotFound();
            }

            if (cart.CreatedById != currentUser.Id)
            {
                return Forbid();
            }

            cart.ShippingData = JsonConvert.SerializeObject(deliveryInformationVm);
            cart.OrderNote = deliveryInformationVm.OrderNote;
            _cartRepository.SaveChanges();
            var orderCreateResult = await _orderService.CreateOrder(cart.Id, "CashOnDelivery", 0);

            if (!orderCreateResult.Success)
            {
                return BadRequest(orderCreateResult.Error);
            }

            return Created($"/api/orders/{orderCreateResult.Value.Id}", new { id = orderCreateResult.Value.Id });
        }

        // TODO might need to move to another place
        [HttpGet("api/users/{userId}/addresses")]
        public async Task<IActionResult> UserAddress(long userId, [FromServices] IStormyRepository<CustomerAddress> userAddressRepository, [FromServices] IRepositoryWithTypedId<User,long> userRepository)
        {
            var user = await userRepository.Query().FirstOrDefaultAsync(x => x.Id == userId);
            var defaultAddress = user.Addresses.FirstOrDefault(a => a.IsDefault);
            var defaultAddressId = defaultAddress == null ? 0 : defaultAddress.Id;
            if(user == null)
            {
                return NotFound();
            }

            var userAddress = await userAddressRepository
                .Query()
                .Where(x => (x.Type == AddressType.Shipping) && (x.UserId == userId))
                .Select(x => new ShippingAddressVm
                {
                    UserAddressId = x.Id,
                    ContactName = x.WhoReceives,
                    Phone = x.Details.Phone.FullNumber(),
                    AddressLine1 = x.Details.AddressLine1,
                    CityName = x.Details.City,
                    ZipCode = x.Details.ZipCode,
                    DistrictName = x.Details.DistrictName,
                    StateOrProvinceName = x.Details.State,
                    CountryName = x.Country.Name,
                    IsCityEnabled = x.Country.IsCityEnabled,
                    IsZipCodeEnabled = x.Country.IsZipCodeEnabled,
                    IsDistrictEnabled = x.Country.IsDistrictEnabled
                }).ToListAsync();

            return Ok(new { Addresses = userAddress, DefaultShippingAddressId = defaultAddressId });
        }
    }
}
