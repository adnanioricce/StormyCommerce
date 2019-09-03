using System;
using System.Threading.Tasks;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Entities.Payments;
namespace StormyCommerce.Core.Interfaces.Domain.Payments
{
    public interface IPaymentService<T>
    {
        Task<Result<T>> Charge(Payment payment);
        Task<Result<T>> Refund(Payment payment);
    }
}
