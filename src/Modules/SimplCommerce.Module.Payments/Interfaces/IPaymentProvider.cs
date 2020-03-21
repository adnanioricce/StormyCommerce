using SimplCommerce.Module.Payments.Models;

namespace SimplCommerce.Module.Payments.Interfaces
{
    public interface IPaymentProvider
    {
        void ApplyProviderConfiguration();
        void SetProviderConfiguration(PaymentProvider provider, PaymentProviderAdditionalSettings settings);
        ProcessTransactionResponse ProcessTransaction(ProcessTransactionRequest request);
    }   
}
