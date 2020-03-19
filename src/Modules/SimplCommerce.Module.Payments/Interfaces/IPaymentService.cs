using SimplCommerce.Module.Payments.Models;

namespace SimplCommerce.Module.Payments.Interfaces
{
    public interface IPaymentService
    {
        ProcessTransactionResponse ChargeCart(ProcessTransactionRequest request);   
    }   
}