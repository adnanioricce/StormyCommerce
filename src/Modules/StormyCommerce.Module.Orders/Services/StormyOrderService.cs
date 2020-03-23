using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FluentValidation.Results;
using SimplCommerce.Infrastructure;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Orders.Areas.Orders.ViewModels;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.Orders.Services;
using SimplCommerce.Module.Shipments.Services;
using SimplCommerce.Module.ShoppingCart.Models;
using SimplCommerce.Module.ShoppingCart.Services;
using StormyCommerce.Module.Orders.Validators.Carts;

namespace StormyCommerce.Module.Orders.Services
{
    public class StormyOrderService : IOrderService
    {
        private readonly IRepository<Cart> _CartRepository;
        private readonly IFreightCalculator _freightCalculator;
        public StormyOrderService(IRepository<Cart> cartService, IFreightCalculator freightCalculator)
        {
            _CartRepository = cartService;
            _freightCalculator = freightCalculator;
        }

        public void CancelOrder(Order order)
        {
            throw new System.NotImplementedException();
        }
        //TODO:this method should be(most part at least) implemented on CartService
        public async Task<Result<Order>> CreateOrder(long cartId, string paymentMethod, decimal paymentFeeAmount, OrderStatus orderStatus = OrderStatus.New)
        {
            var cart = _CartRepository.Query().Where(c => c.Id == cartId).FirstOrDefault();
            var cartValidator = new CartToOrderValidator();
            var result = cartValidator.Validate(cart);
            if (!result.IsValid)
            {
                string message = BuildErrorMessage(result.Errors);
                return Result.Fail<Order>(message);
            }
            //TODO(optional):Check for discount
            //TODO:don't depend on this, ensure that the data received is of the internal Address model
            var shippingData = JsonSerializer.Deserialize<Address>(cart.ShippingData);
            var freightResponse = await _freightCalculator.CalculateFreightForPackage(new SimplCommerce.Module.Shipments.Models.Requests.CalculatePackageFreightRequest
            {
                CartId = cart.Id,
                ShippingMethod = cart.ShippingMethod,
                DestinationZipCode = shippingData.ZipCode
            });
            //TODO:Change the shipping service selection to somethging like this, you alreadly have the shipping method
            //freightResponse.Options.Where(o => GetServiceName(o.ServiceName, cart.ShippingMethod));
            //TODO:Validate shipping
            if (freightResponse.Options.Count <= 0)
            {
                return Result.Fail<Order>("there's no shipping option for your region");
            }            
            //TODO:Create a shipping method here
            cart.ShippingAmount = freightResponse.Options
                .Where(o => string.Equals(o.ServiceName,cart.ShippingMethod,StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault()
                .Price;
            ////TODO:Calculate Shipping           
            //TODO:Prepare Shipping

            //TODO:this also is not good
            var billingAddress = MapToOrderAddress(shippingData);            
            var shippingAddress = MapToOrderAddress(shippingData);
            var orderAmount = cart.Items.Sum(i => i.Quantity * i.Product.Price);
            if (cart.ShippingAmount.HasValue)
            {
                orderAmount += cart.ShippingAmount.Value;
            }
            var order = new Order
            {
                CreatedById = cart.CreatedById,
                CustomerId = cart.CustomerId,
                LatestUpdatedById = cart.CustomerId,
                ShippingFeeAmount = cart.ShippingAmount.Value,
                ShippingMethod = cart.ShippingMethod,
                OrderTotal = cart.ShippingAmount.HasValue ? cart.ShippingAmount.Value + orderAmount : orderAmount,
                PaymentMethod = paymentMethod,
                SubTotal = orderAmount,
                SubTotalWithDiscount = orderAmount,
                PaymentFeeAmount = paymentFeeAmount,
                OrderStatus = orderStatus,
                //TODO:Perform same task on Sub orders
                IsMasterOrder = false,

                //DiscountAmount = couponDiscount,
                BillingAddress = new OrderAddress(billingAddress),
                ShippingAddress = new OrderAddress(shippingAddress),
            };
            return Result.Ok(order);
        }


        public Task<Result<Order>> CreateOrder(long cartId, string paymentMethod, decimal paymentFeeAmount, string shippingMethod, Address billingAddress, Address shippingAddress, OrderStatus orderStatus = OrderStatus.New)
        {
            throw new System.NotImplementedException();
        }

        public Task<decimal> GetTax(long cartId, string countryId, long stateOrProvinceId, string zipCode)
        {
            throw new System.NotImplementedException();
        }

        public Task<OrderTaxAndShippingPriceVm> UpdateTaxAndShippingPrices(long cartId, TaxAndShippingPriceRequestVm model)
        {
            throw new System.NotImplementedException();
        }        
        private string BuildErrorMessage(IList<ValidationFailure> errors)
        {
            StringBuilder errorBuilder = new StringBuilder();
            errorBuilder.Append("Errors on order process:\n ");
            foreach (var error in errors)
            {
                errorBuilder.Append($"\t Error code {error.ErrorCode}\n Error message:{error.ErrorMessage} \n Value passed {error.AttemptedValue}\n property name :{error.PropertyName} \n");
            }
            return errorBuilder.ToString();
        }
        private Address MapToOrderAddress(Address address)
        {
            return new Address
            {
                AddressLine1 = address.AddressLine1,
                AddressLine2 = address.AddressLine2,
                ContactName = address.ContactName,
                CountryId = address.CountryId,
                StateOrProvinceId = address.StateOrProvinceId,
                DistrictId = address.DistrictId,
                City = address.City,
                ZipCode = address.ZipCode,
                Phone = address.Phone
            };
        }
    }   
}
