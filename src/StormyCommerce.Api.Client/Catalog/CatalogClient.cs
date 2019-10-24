using System;
using System.Collections.Generic;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using SimplCommerce.Infrastructure.Extensions;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

namespace StormyCommerce.Api.Client.Catalog
{
    public class CatalogClient : ICatalogClient
    {
        private string _baseUrl = "https://localhost:443";
        public string BaseUrl { get { return _baseUrl; } set { _baseUrl = value; } }
        private readonly HttpClient _client = new HttpClient();
        public CatalogClient(string baseUrl)
        {
            _baseUrl = BaseUrl;
            _client.BaseAddress = new Uri(baseUrl);
        }
        private async Task<Result> Post<T>(string endpoint,T model)
        {
            var response = await _client.PostAsJsonAsync(endpoint, model);
            var result = await response.Content.ReadAsAsync<Result>();
            return result;
        }
        private async Task<T> Get<T>(string endpoint,long? id)
        {
            if(id == null)
            {
                var response = await _client.GetAsync(endpoint);
                return await response.Content.ReadAsAsync<T>();
            }
            var path = String.Format($"{endpoint}?id={0}", id);
            var result = await _client.GetAsync(path);
            return await result.Content.ReadAsAsync<T>();
        }

        public Task<Result> CreateCategoryAsync(Category category = null, CancellationToken cancellationToken = default)
        {
            return Post("/api/Category/create", category);
        }

        public Task<Result> CreateProductAsync(StormyProduct _model = null, CancellationToken cancellationToken = default)
        {
            return Post("/api/Product/create", _model);
        }

        public Task<Result> EditCategoryAsync(Category category = null, CancellationToken cancellationToken = default)
        {
            return Post("/api/Category/edit", category);
        }

        public Task<Result> EditProductAsync(StormyProduct _model = null, CancellationToken cancellationToken = default)
        {
            return Post("/api/Product/edit",_model);
        }

        public Task<List<CategoryDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return Get<List<CategoryDto>>("/api/Category/list", null);
        }

        public Task<List<ProductDto>> GetAllProductsAsync(long? startIndex = null, long? endIndex = null, CancellationToken cancellationToken = default)
        {
            return Get<List<ProductDto>>($"/api/Product?startIndex={startIndex}&endIndex={endIndex}", null);
        }

        public Task<List<ProductDto>> GetAllProductsOnCategoryAsync(int? categoryId = null, int? limit = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> GetAllProductsOnHomepageAsync(int? limit = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetCategoryByIdAsync(long? id = null, CancellationToken cancellationToken = default)
        {
            return Get<CategoryDto>($"/api/Category", id);
        }

        public Task<int> GetNumberOfProductsInCategoryAsync(IEnumerable<long> categoryIds = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProductByIdAsync(long? id = null, CancellationToken cancellationToken = default)
        {
            return Get<ProductDto>("/api/Product", id);
        }

        public Task<ProductOverviewDto> GetProductOverviewAsync(long? id = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
