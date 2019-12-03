using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Core.Models.Requests;

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
        public CatalogClient(HttpClient client)
        {
            _client = client;
        }
        private async Task<Result> Post<T>(string endpoint,T model)
        {            
            var response = await _client.PostAsJsonAsync(endpoint, model);
            var result = await response.Content.ReadAsAsync<Result>();
            return result;
        }
        private async Task<T> Get<T>(string endpoint,long? id)
        {
            if(id == null || id == 0)
            {
                var response = await _client.GetAsync(endpoint);
                return await response.Content.ReadAsAsync<T>();
            }
            var path = String.Format($"{endpoint}?id={0}", id);
            var result = await _client.GetAsync(path);
            return await result.Content.ReadAsAsync<T>();
        }
        private async Task<T> Get<T>(string endpoint,params long[] ids)
        {            
            var stringBuilder = new StringBuilder();            
            stringBuilder.AppendJoin($"categoryIds={0}",ids);
            var path = String.Format($"/api/Product/getlength/category?{stringBuilder.ToString()}");
            var result = await _client.GetAsync(path);
            return await result.Content.ReadAsAsync<T>();
        }

        public Task<Result> CreateCategoryAsync(Category category = null, CancellationToken cancellationToken = default)
        {
            return Post("/api/Category/create", category);
        }

        public Task<Result> CreateProductAsync(CreateProductRequest _model = null, CancellationToken cancellationToken = default)
        {
            return Post("/api/Product/create", _model);
        }

        public async Task<Result> EditCategoryAsync(Category category = null, CancellationToken cancellationToken = default)
        {
            var response = await _client.PutAsJsonAsync("/api/Product/edit",category);
            var result = await response.Content.ReadAsAsync<Result>();
            return result;
        }

        public Task<Result> EditProductAsync(StormyProduct _model = null, CancellationToken cancellationToken = default)
        {
            return Post("/api/Product/edit",_model);
        }

        public Task<List<CategoryDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return Get<List<CategoryDto>>("/api/Category/list", 0);
        }

        public Task<List<ProductDto>> GetAllProductsAsync(long? startIndex = null, long? endIndex = null, CancellationToken cancellationToken = default)
        {
            return Get<List<ProductDto>>($"/api/Product?startIndex={startIndex}&endIndex={endIndex}", 0);
        }

        public Task<List<ProductDto>> GetAllProductsOnCategoryAsync(int? categoryId = null, int? limit = null, CancellationToken cancellationToken = default)
        {
            return Get<List<ProductDto>>($"/api/Product/list/category?limit={limit}",categoryId);
        }

        public Task<List<ProductDto>> GetAllProductsOnHomepageAsync(int? limit = null, CancellationToken cancellationToken = default)
        {            
            return Get<List<ProductDto>>($"/api/Product/homepage?limit={limit}",0);
        }

        public Task<CategoryDto> GetCategoryByIdAsync(long? id = null, CancellationToken cancellationToken = default)
        {
            return Get<CategoryDto>($"/api/Category", id);
        }

        public Task<int> GetNumberOfProductsInCategoryAsync(IEnumerable<long> categoryIds = null, CancellationToken cancellationToken = default)
        {
            return Get<int>("/api/Product/getlength/category",categoryIds.ToArray());
        }
        public Task<ProductDto> GetProductByIdAsync(long? id = null, CancellationToken cancellationToken = default)
        {
            return Get<ProductDto>("/api/Product", id);
        }
        public Task<ProductOverviewDto> GetProductOverviewAsync(long? id = null, CancellationToken cancellationToken = default)
        {
            return Get<ProductOverviewDto>("/api/Product/get_overview",id);
        }
    }
}
