using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Services.Catalog
{
    public class ProductService : IProductService
    {
        private const string ProductEntityTypeId = "Product";
        private readonly IStormyRepository<StormyProduct> _productRepository;        

        public ProductService(IStormyRepository<StormyProduct> productRepository)
        {
            _productRepository = productRepository;
        }

        //TODO:write failing test cases
        public async Task<Result<IList<StormyProduct>>> GetAllProductsByCategory(int categoryId, int limit = 15)
        {
            return new Result<IList<StormyProduct>>(await _productRepository.Table.Where(product => product.CategoryId == categoryId && product.Id <= limit).ToListAsync(), true, "none");
        }

        public async Task DeleteProduct(StormyProduct product)
        {
            product.IsDeleted = true;
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProducts(IList<StormyProduct> products)
        {
            await UpdateProductsAsync(products);
        }

        //!this look very lazy
        public async Task<IList<StormyProduct>> GetAllProductsDisplayedOnHomepageAsync(int limit)
        {
            return await _productRepository
                .Table
                .Where(f => f.Ranking <= limit)//use !
                .ToListAsync();
        }

        //TODO:Create other method for the includes
        public async Task<IList<StormyProduct>> GetAllProductsAsync(long startIndex = 1, long endIndex = 15)
        {
            return await _productRepository.Table
                .Where(product => product.Id <= endIndex && product.Id >= startIndex)
                .ToListAsync();
        }

        public async Task<IList<StormyProduct>> GetAllProductsIncludingAsync(long startIndex = 1, long endIndex = 15)
        {
            return await _productRepository.Table
                .Include(product => product.Brand)
                .Include(product => product.Category)
                .Include(product => product.LinkedProductLinks)
                .Include(product => product.Links)
                .Include(product => product.Medias)
                .Include(product => product.OptionValues)
                .Include(product => product.Vendor)
                .Where(product => product.Id >= startIndex && product.Id <= endIndex)
                .ToListAsync();
            //.Include(product => product.)
        }

        public int GetNumberOfProductsByVendorId(int vendorId)
        {
            return _productRepository.Table.Where(f => f.VendorId == vendorId).Count();
        }
        
        public int GetNumberOfProductsInCategory(IList<long> categoryIds = null)
        {
            if(categoryIds == null) return 0;
            
            var products = new List<StormyProduct>();
            foreach (int id in categoryIds)
            {
                products = _productRepository.Table.Where(p => p.CategoryId == id).ToList();
            }
                                   
            return products.Count;
        }

        public async Task<StormyProduct> GetProductByIdAsync(long productId)
        {
            return await _productRepository.GetByIdAsync(productId);
        }

        public async Task<StormyProduct> GetProductBySkuAsync(string sku)
        {
            return await Task.Run(() => _productRepository.Table.FirstOrDefault(entity => entity.SKU == sku));
        }

        public async Task<IList<StormyProduct>> GetProductsByIdsAsync(long[] productIds)
        {
            return await _productRepository.GetAllByIdsAsync(productIds);
        }

        public async Task<IList<StormyProduct>> GetProductsBySkuAsync(string[] skuArray, int vendorId = 0)
        {
            var products = _productRepository.Table.Select(entity => GetProductBySkuAsync(entity.SKU));
            return await Task.WhenAll(products);
        }

        public int GetTotalStockQuantity()
        {
            return _productRepository.Table.Sum(f => f.UnitsInStock - f.UnitsOnOrder);
        }

        public int GetTotalStockQuantityOfProduct(StormyProduct product)
        {
            return _productRepository
                 .Table
                 .Where(p => p.VendorId == product.VendorId)
                 .Sum(p => p.UnitsInStock - p.UnitsOnOrder);
        }

        //TODO:Create slugs with EntityService
        public async Task InsertProductAsync(StormyProduct product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task InsertProductsAsync(IList<StormyProduct> products)
        {
            await _productRepository.AddCollectionAsync(products);
        }

        public async Task UpdateProductAsync(StormyProduct product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task UpdateProductsAsync(IList<StormyProduct> products)
        {
            await _productRepository.UpdateCollectionAsync(products);
        }

        public Task DeleteProductAsync(StormyProduct product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductsAsync(IList<StormyProduct> products)
        {
            throw new NotImplementedException();
        }
    }
}
