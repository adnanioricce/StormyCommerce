using SimplCommerce.Module.Payments.Models;

namespace SimplCommerce.Module.Payments.Interfaces
{
    public interface IPaymentProvider
    {
        void ConfigureProvider(PaymentProvider provider, PaymentProviderAdditionalSettings settings);
        ProcessTransactionResponse ProcessTransaction(ProcessTransactionRequest request)
    }   
}
