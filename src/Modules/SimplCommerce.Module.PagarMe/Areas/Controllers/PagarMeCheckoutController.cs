using Microsoft.AspNetCore.Mvc;
using SimplCommerce.Module.Payments.Interfaces;
using SimplCommerce.Module.Payments.Models;

namespace SimplCommerce.Module.PagarMe.Areas.Controllers
{
    public class PagarMeCheckoutController : ControllerBase
    {
        private readonly IPaymentProvider _paymentProvider;
        public PagarMeCheckoutController(IPaymentProvider paymentProcessor)
        {
            _paymentProvider = paymentProcessor;
        }

        [HttpPost("config")]
        //TODO:Changue PaymentProvider for a web specific model and pass model for additional settings
        public void ConfigureProvider([FromBody]PaymentProvider options)
        {            
            _paymentProvider.ConfigureProvider(options,null);            
        }        
    }
}
