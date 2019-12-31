using System;
using System.Threading.Tasks;


namespace StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices
{
    public interface IPaymentMethod
    {
        Task<ProcessPaymentResponse> ProccessPaymentAsync(ProcessPaymentRequest request);
        Task<ChargeCreditCardResponse> ChargePaymentAsync(ChargeCreditCardRequest request);
        Task<ChargeBoletoResponse> ChargeBoletoAsync(ChargeBoletoRequest request);
        Task<RefundPaymentResponse> RefundPaymentAsync(RefundPaymentRequest request);
        Task<CancelPaymentResponse> CancelPaymentAsync(CancelPaymentRequest request);
    }
}
