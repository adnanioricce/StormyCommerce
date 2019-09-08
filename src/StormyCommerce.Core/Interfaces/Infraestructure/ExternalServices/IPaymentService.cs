using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Infraestructure.ExternalServices
{
    public interface IPaymentService
    {
        Task<Result> Charge(PaymentDto payment);

        Task<Result> Refund(PaymentDto payment);

        Task<Result> Cancel(PaymentDto payment);

        // Task<PaymentDto> GetPaymentById(long id)
    }
}
