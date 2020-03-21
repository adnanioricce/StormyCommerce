namespace SimplCommerce.Module.PagarMe.Areas.Controllers
{
    public class PagarMeCheckoutController : BaseController
    {
        private readonly IPaymentProcessor _paymentProcessor;
        public PagarMeCheckoutController(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        [HttpPost("config")]
        public void ConfigureProvider([FromBody]PaymentProviderOptions options)
        {
            _paymentProcessor.ConfigureProvider(options);
            return Ok();
        }        
    }
}