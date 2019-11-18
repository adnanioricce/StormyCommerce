using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Domain.Catalog
{
    public interface IProductService
    {
        
        Task DeleteProductAsync(StormyProduct product);

        Task DeleteProductsAsync(IList<StormyProduct> products);
        Task<List<StormyProduct>> SearchProductsBySearchPattern(string searchPattern);

        Task<Result<IList<StormyProduct>>> GetAllProductsByCategory(int categoryId, int limit = 15);

        Task<IList<StormyProduct>> GetAllProductsDisplayedOnHomepageAsync(int limit = 0);

        Task<IList<StormyProduct>> GetAllProductsAsync(long startIndex, long endIndex);

        Task<StormyProduct> GetProductByIdAsync(long productId);
        Task<StormyProduct> GetProductByNameAsync(string productName);

        Task<IList<StormyProduct>> GetProductsByIdsAsync(long[] productIds);
        

        Task InsertProductAsync(StormyProduct product);

        Task UpdateProductAsync(StormyProduct product);

        Task UpdateProductsAsync(IList<StormyProduct> products);

        int GetNumberOfProductsInCategory(IList<long> categoryIds = null);

        Task<StormyProduct> GetProductBySkuAsync(string sku);

        Task<IList<StormyProduct>> GetProductsBySkuAsync(string[] skuArray, int vendorId = 0);
        int GetNumberOfProducts();
        int GetNumberOfProductsByVendorId(int vendorId);

        //TODO: Still have to create a tag entities
        //bool ProductTagExists(StormyProduct product, int productTagId);
        int GetTotalStockQuantity();

        int GetTotalStockQuantityOfProduct(StormyProduct product);

        Task InsertProductsAsync(IList<StormyProduct> products);
    }
}
