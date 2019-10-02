using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Stormycommerce.Module.Orders.Area.ViewModels;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;

namespace StormyCommerce.Api.Client.Catalog
{
    // public class CatalogClient : IClient
    // {
        // private string _baseUrl = "https://localhost:443";
        // public string BaseUrl { get { return _baseUrl; } set { _baseUrl = value; } }
        // //protected JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

        // //partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
        // //partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        // //partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        // //partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);


        // public Task<Result> AddAddressAsync(Address address = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> CheckoutBoletoAsync(CheckoutOrderVm checkoutVm = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> ConfirmEmailAsync(string email = null, string code = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> CreateCategoryAsync(Category category = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> CreateCustomerAsync(CustomerDto customerDto = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> CreateOrderAsync(OrderDto orderDto = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> CreateProductAsync(ProductDto _model = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> EditCategoryAsync(string id, Category category = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> EditProductAsync(ProductDto _model = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> ForgotPasswordAsync(ForgotPasswordViewModel model = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result<ICollection<CategoryDto>>> GetAllAsync(CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result<ICollection<ProductDto>>> GetAllProductsAsync(long? startIndex = null, long? endIndex = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result<ICollection<ProductDto>>> GetAllProductsOnCategoryAsync(int? categoryId = null, int? limit = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result<ICollection<ProductDto>>> GetAllProductsOnHomepageAsync(int? limit = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result<CategoryDto>> GetCategoryByIdAsync(long id, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result<CustomerDto>> GetCustomerByEmailOrUsernameAsync(string email = null, string username = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result<ICollection<StormyCustomer>>> GetCustomersAsync(int? minLimit = null, long? maxLimit = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result<int>> GetNumberOfProductsInCategoryAsync(IEnumerable<int> categoryIds = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result<ProductDto>> GetProductByIdAsync(string _0, long? id = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result<ProductOverviewDto>> GetProductOverviewAsync(string _0, long? id = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result<string>> LoginAsync(SignInVm signInVm = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> RegisterAsync(SignUpVm signUpVm = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> ResetPasswordAsync(ResetPasswordViewModel model = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> SeedDatabaseAsync(CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Result> WriteReviewAsync(CustomerReviewDto review = null, CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }
        //    private System.Net.Http.HttpClient _httpClient;
        //    private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

        //    public Client(System.Net.Http.HttpClient httpClient)
        //    {
        //        _httpClient = httpClient;
        //        _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(() =>
        //        {
        //            var settings = new Newtonsoft.Json.JsonSerializerSettings();
        //            UpdateJsonSerializerSettings(settings);
        //            return settings;
        //        });
        //    }
    // }
}
