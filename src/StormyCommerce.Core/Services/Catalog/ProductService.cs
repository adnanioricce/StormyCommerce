using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces.Domain;
using Microsoft.EntityFrameworkCore;

namespace StormyCommerce.Core.Services.Catalog
{
    public class ProductService : IProductService
    {
	    private const string ProductEntityTypeId = "Product";
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
        //!this look very lazy
        public async Task<IList<StormyProduct>> GetAllProductsDisplayedOnHomepageAsync(int limit)
        {                               
            return await GetProductsByIdsAsync(productRepository
                .Table
                .Where(f => f.Ranking < limit && f.ProductAvailable == true)
                .Select(p => p.Id)                
                .ToArray());
	    }   
        public async Task<IList<StormyProduct>> GetAllProductsAsync(long startIndex = 0,long endIndex = 15)
        {                        
            return await productRepository.Table                
                .Include(product => product.Medias)
                .Include(product => product.Brand)
                .Include(product => product.Links)
                .Include(product => product.ProductAttributes)            
                .Include(product => product.Vendor)
                .Where(product => product.Id >= startIndex && product.Id <= endIndex)
                .ToListAsync();                                                                                
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
        public async Task<StormyProduct> GetProductByIdAsync(long productId)
        {
            return await productRepository.GetByIdAsync(productId);
        }
        public async Task<StormyProduct> GetProductBySkuAsync(string sku)
        {
            return await Task.Run(() => productRepository.Table.FirstOrDefault(entity => entity.SKU == sku));
        }
        public async Task<IList<StormyProduct>> GetProductsByIdsAsync(long[] productIds)
        {
            return await productRepository.GetAllByIdsAsync(productIds);
        }
        public async Task<IList<StormyProduct>> GetProductsBySkuAsync(string[] skuArray, int vendorId = 0)
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
        //TODO:Create slugs with EntityService
        public async Task InsertProductAsync(StormyProduct product)
        {		    
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
