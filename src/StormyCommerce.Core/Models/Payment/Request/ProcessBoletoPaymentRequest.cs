using System.Collections.Generic;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace StormyCommerce.Core.Models.Payment.Request
{
    public class ProcessBoletoPaymentRequest
    {
        public int Amount { get; set; }
        public string PaymentMethod { get; set; }
        public List<OrderItemDto> Items { get; set; }
        public CustomerDto Customer { get; set; }
        public bool PickUpOnStore { get; set; }
    }
}
