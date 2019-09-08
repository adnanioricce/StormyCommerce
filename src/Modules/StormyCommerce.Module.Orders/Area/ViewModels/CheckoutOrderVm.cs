using System.Collections.Generic;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;

namespace Stormycommerce.Module.Orders.Area.ViewModels
{
    //TODO:Define validation
    public class CheckoutOrderVm
    {
        public AddressVm Address { get; set; }
        public decimal DeliveryCost { get; set; }
        public decimal Discount { get; set; }
        public List<ProductDto> Items { get; set; }        
        //TODO: Change to a enum
        public string PaymentMethod { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal ShippingFee { get; set; }        
        
        
        
        
    }
}