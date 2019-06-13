using StormyCommerce.Core.Entities.Product;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Domain.Catalog
{
    public interface IProductService
    {        
        void DeleteProduct(StormyProduct product);        
        void DeleteProducts(IList<StormyProduct> products);                      
        Task<ICollection<StormyProduct>> GetAllProductsDisplayedOnHomepageAsync(int limit = 0);                           
        Task<StormyProduct> GetProductByIdAsync(int productId);        
        Task<ICollection<StormyProduct>> GetProductsByIdsAsync(int[] productIds);        
        Task InsertProductAsync(StormyProduct product);        
        Task UpdateProductAsync(StormyProduct product);                
        Task UpdateProductsAsync(IList<StormyProduct> products);        
        int GetNumberOfProductsInCategory(IList<int> categoryIds = null, int storeId = 0);                                       
        Task<StormyProduct> GetProductBySkuAsync(string sku);        
        Task<ICollection<StormyProduct>> GetProductsBySkuAsync(string[] skuArray, int vendorId = 0);                      
        int GetNumberOfProductsByVendorId(int vendorId);                                 
        //TODO: Still have to create a tag entities
        //bool ProductTagExists(StormyProduct product, int productTagId);                      
        int GetTotalStockQuantity();
        int GetTotalStockQuantityOfProduct(StormyProduct product);
        Task InsertProductsAsync(IList<StormyProduct> products);
    }
}
