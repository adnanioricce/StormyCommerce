using SimplCommerce.Module.Payments.Interfaces;
using SimplCommerce.Infraestructure.Data;
namespace SimplCommerce.Module.PagarMe.Services
{
    public class PagarMeProcessor : IPaymentProvider
    {        
        private readonly IRepository<Order> _orderRepository;        
        // private readonly IRepository<>
        public PagarMeProcessor()
        {
            
        }
        public ProcessTransactionResponse ProcessTransaction(ProcessTransactionRequest request)
        {
            //PaymentProcessor 
            var order = _orderRepository.Query().FirstOrDefault(o => o.Id == request.OrderId);
            return new ProcessTransactionResponse{
                Success = false
            };
        }
    }
}
