using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;

namespace StormyCommerce.Module.Orders.Area.Models.Orders
{
    public class BoletoCheckoutRequest
    {                
        [Required]
        public int Amount { get; set; }
        public string PaymentMethod { get; } = "boleto";        
        public DateTime ExpirationDate { get; set; }
        public bool Capture { get; set; } = true;        
        public string PostbackUrl { get; set; }
        [Required]
        public List<OrderItemDto> Items { get; set; }        
        public string ShippingMethod { get; set; }

    }
}
