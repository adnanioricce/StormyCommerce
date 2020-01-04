using System;
using System.Threading.Tasks;
using StormyCommerce.Module.Payments.Models.Requests;

namespace StormyCommerce.Module.Payments.Interfaces
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
