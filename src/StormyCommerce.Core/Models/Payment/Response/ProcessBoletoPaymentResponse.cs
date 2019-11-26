using StormyCommerce.Core.Entities;

namespace StormyCommerce.Core.Models.Payment.Response
{
    public class ProcessBoletoPaymentResponse
    {
        public StormyOrder Order { get; set; }
        public Result Result { get; set; }
    }
}
