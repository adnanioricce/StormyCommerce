using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StormyCommerce.Api.Client.Customer
{
    public interface ICustomerClient
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> AddAddressAsync(CustomerAddress address = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> WriteReviewAsync(CustomerReviewDto review = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result<ICollection<StormyCustomer>>> GetCustomersAsync(int? minLimit = null, long? maxLimit = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result<CustomerDto>> GetCustomerByEmailOrUsernameAsync(string email = null, string username = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> CreateCustomerAsync(CustomerDto customerDto = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
