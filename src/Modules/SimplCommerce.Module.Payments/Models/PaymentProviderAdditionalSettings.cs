using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Module.Payments.Models
{
    public abstract class PaymentProviderAdditionalSettings
    {
        public string ApiKey { get; set; }
        public string DefaultEncryptionKey { get; set; }
        public decimal PaymentTaxAmount { get; set; }        
    }
}
