using StormyCommerce.Core.Entities.Payments;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Payment.Request;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices
{
    public interface IPaymentService
    {
        Task<Result> Charge(PaymentDto payment);

        Task<Result> Refund(PaymentDto payment);

        Task<Result> Cancel(PaymentDto payment);
        Task AddPaymentAsync(Payment payment);
        Task<PaymentDto> GetPaymentById(long id);        
    }
}
