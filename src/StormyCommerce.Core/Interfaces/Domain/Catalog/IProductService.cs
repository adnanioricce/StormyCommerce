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
        Task<ICollection<StormyProduct>> GetAllProductsDisplayedOnHomepageAsync(int? limit = null);                
        Task<StormyProduct> GetProductByIdAsync(int productId);        
        Task<ICollection<StormyProduct>> GetProductsByIdsAsync(int[] productIds);        
        Task InsertProductAsync(StormyProduct product);        
        Task UpdateProductAsync(StormyProduct product);                
        Task UpdateProductsAsync(IList<StormyProduct> products);        
        int GetNumberOfProductsInCategory(IList<int> categoryIds = null, int storeId = 0);                        
        void UpdateProductReviewTotals(StormyProduct product);                  
        Task<StormyProduct> GetProductBySkuAsync(string sku);        
        Task<ICollection<StormyProduct>> GetProductsBySkuAsync(string[] skuArray, int vendorId = 0);                      
        int GetNumberOfProductsByVendorId(int vendorId);                   
        bool ProductIsAvailable(StormyProduct product, DateTime? dateTime = null);              
        //TODO: Still have to create a tag entities
        //bool ProductTagExists(StormyProduct product, int productTagId);                      
        int GetTotalStockQuantity(StormyProduct product, bool useReservedQuantity = true, int warehouseId = 0);                        
    }
}
