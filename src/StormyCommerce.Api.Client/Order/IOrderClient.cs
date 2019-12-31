using System;
using System.Threading;
using System.Threading.Tasks;
using SimplCommerce.Infrastructure;
using Stormycommerce.Module.Orders.Area.ViewModels;
 

namespace StormyCommerce.Api.Client.Order
{
    public interface IOrderClient
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> CreateOrderAsync(OrderDto orderDto = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> CheckoutBoletoAsync(CheckoutOrderVm checkoutVm = null, CancellationToken cancellationToken = default(CancellationToken));            
    }
}
