using StormyCommerce.Core.Entities;

namespace StormyCommerce.Core.Models.Payment.Response
{
    public class ProcessPaymentResponse
    {
        public ProcessPaymentResponse()
        {

        }
        public ProcessPaymentResponse(StormyOrder order,Result result)
        {
            Order = order;
            Result = result;
        }
        public StormyOrder Order { get; set; }
        public Result Result { get; set; }
    }
}
