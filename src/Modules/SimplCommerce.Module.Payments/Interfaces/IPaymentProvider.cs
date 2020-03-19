using SimplCommerce.Module.Payments.Models;

namespace SimplCommerce.Module.Payments.Interfaces
{
    public interface IPaymentProvider
    {
        ProcessTransactionResponse ProcessTransaction(ProcessTransactionRequest request)
    }   
}