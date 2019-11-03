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
        private readonly IStormyRepository<StormyProduct> _productRepository;           

        //TODO: I Think a service for this is unecessary        
        public ProductService(IStormyRepository<StormyProduct> productRepository        
        )
        {
            _productRepository = productRepository;
            _productRepository
            .Table
            .Include(p => p.Brand)
            .Include(p => p.Category)
                .ThenInclude(c => c.Parent)
            .Include(p => p.Vendor)
            .Include(p => p.Medias)
            .Load();
        }
        #region Read Methods
        //TODO:write failing test cases
        public async Task<Result<IList<StormyProduct>>> GetAllProductsByCategory(int categoryId, int limit = 15)
        {
            return new Result<IList<StormyProduct>>(await _productRepository.Table
            .Where(product => product.CategoryId == categoryId)
            .Take(limit)
            .ToListAsync(), true, "none");
        }
        public async Task<IList<StormyProduct>> GetAllProductsDisplayedOnHomepageAsync(int limit)
        {
            return await _productRepository
                .Table
                .Take(limit)
                .ToListAsync();
        }

        //TODO:Create other method for the includes
        public async Task<IList<StormyProduct>> GetAllProductsAsync(long startIndex = 1, long endIndex = 15)
        {
            return await _productRepository.Table
                .Include(prop => prop.Category)
                .Include(prop => prop.Medias)
                .Include(prop => prop.Brand)
                .Include(prop => prop.Vendor)
                .Where(product => product.Id <= endIndex && product.Id >= startIndex)
                .ToListAsync();
        }

        public async Task<IList<StormyProduct>> GetAllProductsIncludingAsync(long startIndex = 1, long endIndex = 15)
        {
            return await _productRepository.Table
                .Include(product => product.Brand)
                .Include(product => product.Category)
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
            if (categoryIds == null) return 0;

            var products = new List<StormyProduct>();
            foreach (int id in categoryIds)
            {
                products = _productRepository.Table.Where(p => p.CategoryId == id).ToList();
            }

            return products.Count;
        }

        public async Task<StormyProduct> GetProductByIdAsync(long productId)
        {
            return await _productRepository.Table
            .Include(p => p.Brand)
            .Include(p => p.Category)
            .Include(p => p.Vendor)
            .Include(p => p.Medias)
            .Where(p => p.Id == productId)
            .FirstAsync();
        }

        public async Task<StormyProduct> GetProductBySkuAsync(string sku)
        {
            return await _productRepository.Table
            .Where(p => p.SKU.Equals(sku, StringComparison.OrdinalIgnoreCase))
            .FirstAsync();
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
        #endregion
        #region Delete methods
        public async Task DeleteProduct(StormyProduct product)
        {
            product.IsDeleted = true;
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProducts(IList<StormyProduct> products)
        {
            products.ToList().ForEach(p => p.IsDeleted = true);
            await UpdateProductsAsync(products);
        }
        public async Task DeleteProductAsync(StormyProduct product)
        {
            var entry = await _productRepository.GetByIdAsync(product.Id) ?? throw new ArgumentNullException("product don't exist");
            try{
                _productRepository.Delete(entry);
            } catch(Exception ex){                
                throw ex; 
            }

        }
        public Task DeleteProductsAsync(IList<StormyProduct> products)
        {
            throw new NotImplementedException();
        }
        #endregion                
        #region Insert Methods
        //TODO:Create slugs with EntityService
        public async Task InsertProductAsync(StormyProduct product)
        {                                 
            product.Price = Price.GetPriceFromCents("R$",product.UnitPrice);
            product.OldPrice = Price.GetPriceFromCents("R$",product.UnitPrice);            
            try 
            {                
                await _productRepository.AddAsync(product);
                                                                                        
            } catch (Exception ex) {
                throw ex;
            }
            var createdProduct = await _productRepository.Table
                .Where(p => p.Id == product.Id)
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.Medias)
                .Include(p => p.Links)
                .FirstOrDefaultAsync();                                
            createdProduct.ProductName = createdProduct.ProductName.Replace(' ','-');
            // medias.ForEach(m => createdProduct.AddMedia(m));
            // links.ForEach(link => createdProduct.AddProductLinks(link));
            // await _productRepository.UpdateAsync(createdProduct);
        }

        public async Task InsertProductsAsync(IList<StormyProduct> products)
        {
            await _productRepository.AddCollectionAsync(products);
        }
        #endregion
        #region Update Methods
        public async Task UpdateProductAsync(StormyProduct product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task UpdateProductsAsync(IList<StormyProduct> products)
        {
            await _productRepository.UpdateCollectionAsync(products);
        }

        public async Task<List<StormyProduct>> SearchProductsBySearchPattern(string searchPattern)
        {
            return await _productRepository.Table
                .Where(p => EF.Functions.Like(p.ProductName, "%" + searchPattern + "%"))
                //.Where(p => EF.Functions.Like(p.ShortDescription, $"%{searchPattern}%"))
                .ToListAsync();                                        
        }
        #endregion
        private bool IsSlugValid(StormyProduct product,string brandName,string categoryName)
        {
            return product.ProductName.Contains(brandName) && product.ProductName.Contains(categoryName);
        }

    }
}
