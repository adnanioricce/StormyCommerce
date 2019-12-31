
using System.Threading.Tasks;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Module.Payments.Models.Requests;

namespace StormyCommerce.Module.Payments.Interfaces
{
    public interface IPaymentProcessor
    {        
        Task<ProcessPaymentResponse> ProcessBoletoPaymentRequestAsync(CheckoutBoletoRequest request,CustomerDto customerDto);
        Task<ProcessPaymentResponse> ProcessCreditCardPaymentAsync(CheckoutCreditCardRequest request, CustomerDto customerDto);
        //TODO:PostPaymentProcess Method
    }
}
