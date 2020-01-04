using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Orders.Areas.Orders.ViewModels;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.Pricing.Services;
using SimplCommerce.Module.ShippingPrices.Services;
using SimplCommerce.Module.ShoppingCart.Models;
using SimplCommerce.Module.Tax.Services;
using SimplCommerce.Module.Orders.Events;
using SimplCommerce.Module.ShoppingCart.Services;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Entities.Address;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Entities.Common;

namespace SimplCommerce.Module.Orders.Services
{
    public class OrderService : IOrderService
    {
        private readonly IStormyRepository<Cart> _cartRepository;
        private readonly IStormyRepository<Order> _orderRepository;
        private readonly ICouponService _couponService;
        private readonly IStormyRepository<CartItem> _cartItemRepository;
        private readonly IStormyRepository<OrderItem> _orderItemRepository;
        private readonly ITaxService _taxService;
        private readonly ICartService _cartService;
        private readonly IShippingPriceService _shippingPriceService;
        private readonly IStormyRepository<CustomerAddress> _userAddressRepository;
        private readonly IMediator _mediator;

        public OrderService(IStormyRepository<Order> orderRepository,
            IStormyRepository<Cart> cartRepository,
            ICouponService couponService,
            IStormyRepository<CartItem> cartItemRepository,
            IStormyRepository<OrderItem> orderItemRepository,
            ITaxService taxService,
            ICartService cartService,
            IShippingPriceService shippingPriceService,
            IStormyRepository<CustomerAddress> userAddressRepository,
            IMediator mediator)
        {
            _orderRepository = orderRepository;
            _cartRepository = cartRepository;
            _couponService = couponService;
            _cartItemRepository = cartItemRepository;
            _orderItemRepository = orderItemRepository;
            _taxService = taxService;
            _cartService = cartService;
            _shippingPriceService = shippingPriceService;
            _userAddressRepository = userAddressRepository;
            _mediator = mediator;
        }

        public async Task<Result<Order>> CreateOrder(long cartId, string paymentMethod, decimal paymentFeeAmount, OrderStatus orderStatus = OrderStatus.New)
        {
            //TODO: See git file history
            throw new NotImplementedException();
        }

        public async Task<Result<Order>> CreateOrder(long cartId, string paymentMethod, decimal paymentFeeAmount, string shippingMethodName, CustomerAddress billingAddress, CustomerAddress shippingAddress, OrderStatus orderStatus = OrderStatus.New)
        {
            throw new NotImplementedException();
        }

        private async Task PublishOrderCreatedEvent(Order order)
        {
            var orderCreated = new OrderCreated
            {
                OrderId = order.Id,
                Order = order,
                UserId = order.CreatedById,
                Note = order.OrderNote
            };

            await _mediator.Publish(orderCreated);
        }

        public void CancelOrder(Order order)
        {
            order.OrderStatus = OrderStatus.Canceled;
            order.LatestUpdatedOn = DateTimeOffset.Now;

            var orderItems = _orderItemRepository.Query().Include(x => x.Product).Where(x => x.Order.Id == order.Id);
            foreach (var item in orderItems)
            {
                if (item.Product.StockTrackingIsEnabled)
                {
                    item.Product.UnitsInStock = item.Product.UnitsInStock + item.Quantity;
                }
            }
        }

        public async Task<decimal> GetTax(long cartId, string countryId, long stateOrProvinceId, string zipCode)
        {
            decimal taxAmount = 0;

            var cartItems = _cartItemRepository.Query()
                .Where(x => x.CartId == cartId)
                .Select(x => new CartItemVm
                {
                    Quantity = x.Quantity,
                    Price = x.Product.Price,
                    TaxClassId = x.Product.TaxClass.Id
                }).ToList();

            foreach (var cartItem in cartItems)
            {
                if (cartItem.TaxClassId.HasValue)
                {
                    var taxRate = await _taxService.GetTaxPercent(cartItem.TaxClassId, countryId, stateOrProvinceId, zipCode);
                    taxAmount = taxAmount + cartItem.Quantity * cartItem.Price * taxRate / 100;
                }
            }

            return taxAmount;
        }

        public async Task<OrderTaxAndShippingPriceVm> UpdateTaxAndShippingPrices(long cartId, TaxAndShippingPriceRequestVm model)
        {
            var cart = await _cartRepository.Query().FirstOrDefaultAsync(x => x.Id == cartId);
            if (cart == null)
            {
                throw new ApplicationException($"Cart id {cartId} not found");
            }

            CustomerAddress address;
            if (model.ExistingShippingAddressId != 0)
            {
                address = await _userAddressRepository.Query().Where(x => x.Id == model.ExistingShippingAddressId).FirstOrDefaultAsync();
                if (address == null)
                {
                    throw new ApplicationException($"Address id {model.ExistingShippingAddressId} not found");
                }
            }
            else
            {
                throw new NotImplementedException();
            }

            var orderTaxAndShippingPrice = new OrderTaxAndShippingPriceVm
            {
                Cart = await _cartService.GetActiveCartDetails(cart.CustomerId, cart.CreatedById)
            };

            cart.TaxAmount = orderTaxAndShippingPrice.Cart.TaxAmount = await GetTax(cartId, address.CountryId, address.StateOrProvinceId, address.Details.ZipCode);

            var request = new GetShippingPriceRequest
            {
                OrderAmount = orderTaxAndShippingPrice.Cart.OrderTotal,
                ShippingAddress = address
            };

            orderTaxAndShippingPrice.ShippingPrices = await _shippingPriceService.GetApplicableShippingPrices(request);
            var selectedShippingMethod = string.IsNullOrWhiteSpace(model.SelectedShippingMethodName)
                ? orderTaxAndShippingPrice.ShippingPrices.FirstOrDefault()
                : orderTaxAndShippingPrice.ShippingPrices.FirstOrDefault(x => x.Name == model.SelectedShippingMethodName);
            if (selectedShippingMethod != null)
            {
                cart.ShippingAmount = orderTaxAndShippingPrice.Cart.ShippingAmount = selectedShippingMethod.Price;
                cart.ShippingMethod = orderTaxAndShippingPrice.SelectedShippingMethodName = selectedShippingMethod.Name;
            }

            await _cartRepository.SaveChangesAsync();
            return orderTaxAndShippingPrice;
        }

        private async Task<CouponValidationResult> CheckForDiscountIfAny(Cart cart)
        {
            if (string.IsNullOrWhiteSpace(cart.CouponCode))
            {
                return new CouponValidationResult { Succeeded = true, DiscountAmount = 0 };
            }

            var cartInfoForCoupon = new CartInfoForCoupon
            {
                Items = cart.Items.Select(x => new CartItemForCoupon { ProductId = x.ProductId, Quantity = x.Quantity }).ToList()
            };

            var couponValidationResult = await _couponService.Validate(cart.CustomerId, cart.CouponCode, cartInfoForCoupon);
            return couponValidationResult;
        }

        private async Task<Result<ShippingPrice>> ValidateShippingMethod(string shippingMethodName, CustomerAddress shippingAddress, Cart cart)
        {
            var applicableShippingPrices = await _shippingPriceService.GetApplicableShippingPrices(new GetShippingPriceRequest
            {
                OrderAmount = cart.Items.Sum(x => x.Product.Price * x.Quantity),
                ShippingAddress = shippingAddress
            });

            var shippingMethod = applicableShippingPrices.FirstOrDefault(x => x.Name == shippingMethodName);
            if (shippingMethod == null)
            {
                return Result.Fail<ShippingPrice>($"Invalid shipping method {shippingMethod}");
            }

            return Result.Ok(shippingMethod);
        }
    }
}
