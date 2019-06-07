using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using StormyCommerce.Core.Entities.Product;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;

namespace StormyCommerce.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IStormyRepository<StormyProduct> productRepository;

        public ProductService(IStormyRepository<StormyProduct> _productRepository)
        {
            productRepository = _productRepository;
        }
        public void DeleteProduct(StormyProduct product)
        {
            productRepository.Delete(product);
        }
        public void DeleteProducts(IList<StormyProduct> products)
        {
            productRepository.DeleteCollection(products);
        }
        public async Task<ICollection<StormyProduct>> GetAllProductsDisplayedOnHomepageAsync(int? limit)
        {
            var productCollection = await productRepository.GetAllAsync();
            var homePageProducts = productCollection.Where(f => f.Ranking < 15 && f.ProductAvailable == true);
            return (ICollection<StormyProduct>)homePageProducts;
        }

        public int GetNumberOfProductsByVendorId(int vendorId)
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfProductsInCategory(IList<int> categoryIds = null, int storeId = 0)
        {
            throw new NotImplementedException();
        }

        public async Task<StormyProduct> GetProductByIdAsync(int productId)
        {
            return await productRepository.GetByIdAsync(productId);
        }

        public Task<StormyProduct> GetProductBySkuAsync(string sku)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<StormyProduct>> GetProductsByIdsAsync(int[] productIds)
        {
            return await productRepository.GetAllByIdsAsync(productIds);
        }

        public Task<ICollection<StormyProduct>> GetProductsBySkuAsync(string[] skuArray, int vendorId = 0)
        {
            throw new NotImplementedException();
        }

        public int GetTotalStockQuantity(StormyProduct product, bool useReservedQuantity = true, int warehouseId = 0)
        {
            throw new NotImplementedException();
        }

        public Task InsertProductAsync(StormyProduct product)
        {
            throw new NotImplementedException();
        }
        public bool ProductIsAvailable(StormyProduct product, DateTime? dateTime = null)
        {
            throw new NotImplementedException();
        }
        public async Task UpdateProductAsync(StormyProduct product)
        {
            await productRepository.UpdateAsync(product);
        }

        public void UpdateProductReviewTotals(StormyProduct product)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProductsAsync(IList<StormyProduct> products)
        {
            await productRepository.UpdateCollectionAsync(products);
        }
        
    }
}
