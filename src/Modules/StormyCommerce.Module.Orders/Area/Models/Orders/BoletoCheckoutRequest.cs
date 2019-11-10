using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Module.Orders.Area.ViewModels;

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
        public string DestinationPostalCode { get; set; }
        [Required]
        public List<OrderItemVm> Items { get; set; }        
        public string ShippingMethod { get; set; }

    }
}
