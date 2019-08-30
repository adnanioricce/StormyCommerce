﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces.Domain;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;

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
        public async Task<Result<IList<StormyProduct>>> GetAllProductsByCategory(int categoryId,int limit = 15)
        {            
            return new Result<IList<StormyProduct>>(await _productRepository.Table.Where(product => product.CategoryId == categoryId && product.Id <= limit).ToListAsync(),true,"none");            
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
        public async Task<IList<StormyProduct>> GetAllProductsAsync(long startIndex = 1,long endIndex = 15)
        {                        
            return await _productRepository.Table                
                .Include(product => product.Medias)
                .Include(product => product.Brand)
                .Include(product => product.Links)
                .Include(Product => Product.LinkedProductLinks)
                //.Include(product => product.ProductAttributes)            
                .Include(product => product.Vendor)
                .Include(product => product.Category)
                .Include(product => product.ThumbnailImage)                
                .Where(product => product.Id <= endIndex && product.Id >= startIndex)                
                .ToListAsync();                                                                                
        }

        public int GetNumberOfProductsByVendorId(int vendorId)
        {
            return _productRepository.Table.Where(f => f.VendorId == vendorId).Count();
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
            return _productRepository.Table.Sum(f => f.UnitsInStock);
        }
        public int GetTotalStockQuantityOfProduct(StormyProduct product)
        {
           return _productRepository
                .Table
                .Where(p => p.VendorId == product.VendorId)
                .Sum(p => p.UnitsInStock);
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
