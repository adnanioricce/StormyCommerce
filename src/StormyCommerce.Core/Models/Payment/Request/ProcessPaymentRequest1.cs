using System.Collections.Generic;
using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Core.Models.Order.Request;

namespace StormyCommerce.Core.Models.Payment.Request
{
    public class ProcessPaymentRequest
    {
        public ProcessPaymentRequest(){}
        public ProcessPaymentRequest(CheckoutRequest request,List<OrderItemDto> items,CustomerDto customer)
        {
            Amount = (int)(request.Amount * 100);
            Items = items;
            Customer = customer;
            PaymentMethod = request.PaymentMethod;
            PickUpOnStore = request.PickUpOnStore;
            CardHash = request.CardHash;
        }
        public int Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<OrderItemDto> Items { get; set; }
        public CustomerDto Customer { get; set; }
        public bool PickUpOnStore { get; set; }
        public string CardHash { get; set; }
    }
}
