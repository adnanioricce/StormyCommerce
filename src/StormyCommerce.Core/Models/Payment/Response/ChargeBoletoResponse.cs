using System;

namespace StormyCommerce.Core.Models.Payment.Response
{
    public class ChargeBoletoResponse
    {
        public string BoletoBarCode { get; set; }
        public string BoletoUrl { get; set; }
    }
}
