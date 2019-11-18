using StormyCommerce.Core.Models;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
using System.Threading;
using System.Threading.Tasks;
namespace StormyCommerce.Api.Client
{    
    public interface IAuthenticationClient
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result<string>> LoginAsync(SignInVm signInVm = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> RegisterAsync(SignUpVm signUpVm = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> ConfirmEmailAsync(string email = null, string code = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> ResetPasswordAsync(ResetPasswordViewModel model = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> ForgotPasswordAsync(ForgotPasswordViewModel model = null, CancellationToken cancellationToken = default(CancellationToken));                
    }
}
