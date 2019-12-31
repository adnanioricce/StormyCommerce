namespace StormyCommerce.Module.Payments.Models.Requests
{
    public class ProcessPaymentResponse
    {
        public ProcessPaymentResponse()
        {

        }
        public ProcessPaymentResponse(Order order,Result result)
        {
            Order = order;
            Result = result;
        }
        public Order Order { get; set; }
        public Result Result { get; set; }
    }
}
