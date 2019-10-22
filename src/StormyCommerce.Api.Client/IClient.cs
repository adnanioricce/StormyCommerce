using Stormycommerce.Module.Orders.Area.ViewModels;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace StormyCommerce.Api.Client
{
    //[System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.6.0 (NJsonSchema v10.0.23.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial interface IClient
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

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result<ICollection<CategoryDto>>> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result<CategoryDto>> GetCategoryByIdAsync(long id, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> CreateCategoryAsync(Category category = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> EditCategoryAsync(string id, Category category = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> CheckoutBoletoAsync(CheckoutOrderVm checkoutVm = null, CancellationToken cancellationToken = default(CancellationToken));

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

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> CreateOrderAsync(OrderDto orderDto = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result<ProductOverviewDto>> GetProductOverviewAsync(string _0, long? id = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result<ICollection<ProductDto>>> GetAllProductsAsync(long? startIndex = null, long? endIndex = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result<ICollection<ProductDto>>> GetAllProductsOnHomepageAsync(int? limit = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result<ProductDto>> GetProductByIdAsync(string _0, long? id = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> CreateProductAsync(ProductDto _model = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> EditProductAsync(ProductDto _model = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result<int>> GetNumberOfProductsInCategoryAsync(IEnumerable<int> categoryIds = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result<ICollection<ProductDto>>> GetAllProductsOnCategoryAsync(int? categoryId = null, int? limit = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> SeedDatabaseAsync(CancellationToken cancellationToken = default(CancellationToken));

    }
}
