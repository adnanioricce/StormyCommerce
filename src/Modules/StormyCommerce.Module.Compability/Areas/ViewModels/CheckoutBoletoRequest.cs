using System;
using System.Collections.Generic;
namespace StormyCommerce.Module.Compability.Areas.ViewModels
{
    [Serializable]
    public class CheckoutBoletoRequest
    {                
        public decimal Amount { get; set; }
        
        public int ShippingMethod { get; set; }
        public bool PickUpOnStore { get; set; }        
        public List<object> Items { get; set; }
        public string PaymentMethod { get; set; }
        public string PostalCode { get; set; }                

    }
}