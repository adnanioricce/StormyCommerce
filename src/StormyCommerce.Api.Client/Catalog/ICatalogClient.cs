using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;


using StormyCommerce.Core.Models.Requests;
using static StormyCommerce.Api.Client.Catalog.CatalogClient;
using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Module.Catalog.Models.Dtos;

namespace StormyCommerce.Api.Client.Catalog
{
    public interface ICatalogClient
    {
        ///<summary>
        /// Send a GET request to the server to return all existing non-deleted categories
        /// Envia um pedido POST ao servidor para criar uma nova categoria
        ///</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<List<CategoryDto>> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken));
        ///<summary>
        /// Send a GET request to the server to return a category with the given Id.
        /// Manda um pedido GET para o servidor retornar uma categoria com o Id passado.
        ///</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<CategoryDto> GetCategoryByIdAsync(long? id = null, CancellationToken cancellationToken = default(CancellationToken));
        ///<summary>
        /// send a POST request to create a new category in the server.
        /// Envia um pedido POST ao servidor para criar uma nova categoria
        ///</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> CreateCategoryAsync(Category category = null, CancellationToken cancellationToken = default(CancellationToken));
        ///<summary>
        /// send a PUT request to edit a existing category in the server.
        /// Envia um pedido PUT ao servidor para editar uma categoria existente.
        ///</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> EditCategoryAsync(Category category = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<ProductOverviewDto> GetProductOverviewAsync(long? id = null, CancellationToken cancellationToken = default(CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<List<ProductDto>> GetAllProductsAsync(long? startIndex = null, long? endIndex = null, System.Threading.CancellationToken cancellationToken = default(CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<List<ProductDto>> GetAllProductsOnHomepageAsync(int? limit = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<ProductDto> GetProductByIdAsync(long? id = null, CancellationToken cancellationToken = default(CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> CreateProductAsync(CreateProductRequest _model = null, CancellationToken cancellationToken = default(CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<Result> EditProductAsync(Product _model = null, CancellationToken cancellationToken = default(CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<int> GetNumberOfProductsInCategoryAsync(IEnumerable<long> categoryIds = null, CancellationToken cancellationToken = default(CancellationToken));
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        Task<List<ProductDto>> GetAllProductsOnCategoryAsync(int? categoryId = null, int? limit = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
