using System;
using System.Threading;
using System.Threading.Tasks;
using StormyCommerce.Core.Models;

namespace StormyCommerce.Api.Client.Utils
{
    public interface ISeederClient
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> SeedDatabaseAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
