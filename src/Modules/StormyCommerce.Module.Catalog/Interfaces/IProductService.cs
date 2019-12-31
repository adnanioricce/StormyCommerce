using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Catalog.Interfaces
{
    public interface IProductService
    {
        
        Task DeleteProductAsync(Product product);

        Task DeleteProductsAsync(IList<Product> products);
        Task<List<Product>> SearchProductsBySearchPattern(string searchPattern);

        Task<Result<IList<Product>>> GetAllProductsByCategory(int categoryId, int limit = 15);

        Task<IList<Product>> GetAllProductsDisplayedOnHomepageAsync(int limit = 0);

        Task<IList<Product>> GetAllProductsAsync(long startIndex, long endIndex);

        Task<Product> GetProductByIdAsync(long productId);
        Task<Product> GetProductByNameAsync(string productName);

        Task<IList<Product>> GetProductsByIdsAsync(long[] productIds);
        
        Task InsertProductAsync(Product product);

        Task UpdateProductAsync(Product product);

        Task UpdateProductsAsync(IList<Product> products);

        int GetNumberOfProductsInCategory(IList<long> categoryIds = null);

        Task<Product> GetProductBySkuAsync(string sku);

        Task<IList<Product>> GetProductsBySkuAsync(string[] skuArray, int vendorId = 0);
        int GetNumberOfProducts();
        int GetNumberOfProductsByVendorId(int vendorId);

        //TODO: Still have to create a tag entities
        //bool ProductTagExists(Product product, int productTagId);
        int GetTotalStockQuantity();

        int GetTotalStockQuantityOfProduct(Product product);
        int GetTotalStockQuantityOfProduct(long productId);

        Task InsertProductsAsync(IList<Product> products);
    }
}
