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
	private const string ProductEntityTypeId = "Product";
        private readonly IStormyRepository<StormyProduct> productRepository;
	private readonly IEntityService entityService;

        public ProductService(IStormyRepository<StormyProduct> _productRepository,IEntityService _entityService)
        {
            productRepository = _productRepository;
	    entityService = _entityService;

        }
        public void DeleteProduct(StormyProduct product)
        {
            productRepository.Delete(product);
        }
        public void DeleteProducts(IList<StormyProduct> products)
        {
            productRepository.DeleteCollection(products);
        }
        //!this look very lazy
        public async Task<ICollection<StormyProduct>> GetAllProductsDisplayedOnHomepageAsync(int limit)
        {                        
            return await GetProductsByIdsAsync(productRepository
                .Table
                .Where(f => f.Ranking < limit && f.ProductAvailable == true)
                .Select(f => f.Id)
                .ToArray());
	}
        public async Task<IList<StormyProduct>> GetAllProductsDisplayedOnHomepageAsync(int? limit)
        {
            var productCollection = await productRepository.GetAllAsync();
            var homePageProducts = productCollection.Where(f => f.Ranking < limit && f.ProductAvailable == true);
            return homePageProducts.ToList();
        }

        public int GetNumberOfProductsByVendorId(int vendorId)
        {
            return productRepository.Table.Where(f => f.VendorId == vendorId).Count();
        }
        /// <summary>
        /// NOT IMPLEMENTED, DONT USE
        /// </summary>
        /// <param name="categoryIds"></param>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public int GetNumberOfProductsInCategory(IList<int> categoryIds = null, int storeId = 0)
        {
            throw new NotImplementedException();
        }
        public async Task<StormyProduct> GetProductByIdAsync(int productId)
        {
            return await productRepository.GetByIdAsync(productId);
        }
        public async Task<StormyProduct> GetProductBySkuAsync(string sku)
        {
            return await Task.Run(() => productRepository.Table.FirstOrDefault(entity => entity.SKU == sku));
        }
        public async Task<ICollection<StormyProduct>> GetProductsByIdsAsync(int[] productIds)
        {
            return await productRepository.GetAllByIdsAsync(productIds);
        }
        public async Task<ICollection<StormyProduct>> GetProductsBySkuAsync(string[] skuArray, int vendorId = 0)
        {
            var products = productRepository.Table.Select(entity => GetProductBySkuAsync(entity.SKU));
            return await Task.WhenAll(products);
        }
        public int GetTotalStockQuantity()
        {
            return productRepository.Table.Sum(f => f.UnitsInStock);
        }
        public int GetTotalStockQuantityOfProduct(StormyProduct product)
        {
           return productRepository
                .Table
                .Where(p => p.VendorId == product.VendorId)
                .Sum(p => p.UnitsInStock);
        }
        public async Task InsertProductAsync(StormyProduct product)
        {
		product.Slug = entityService.ToSafeSlug(product.Slug,product.Id,);
		await productRepository.AddAsync(product);            
        }
        public async Task InsertProductsAsync(IList<StormyProduct> products)
        {
            await productRepository.AddCollectionAsync(products);
        }
        public async Task UpdateProductAsync(StormyProduct product)
        {
            await productRepository.UpdateAsync(product);
        }        
        public async Task UpdateProductsAsync(IList<StormyProduct> products)
        {
            await productRepository.UpdateCollectionAsync(products);
        }       
        
        
    }
}
