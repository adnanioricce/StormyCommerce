using SimplCommerce.Module.Payments.Models;

namespace SimplCommerce.Module.Payments.Interfaces
{
    public interface IPaymentProcessor
    {
        ProcessTransactionResponse ProcessTransaction(ProcessTransactionRequest request);   
    }   
}