using Microsoft.EntityFrameworkCore;
using SimplCommerce.Module.Catalog.Models;


using StormyCommerce.Core.Entities.Media;

using StormyCommerce.Core.Interfaces;

using StormyCommerce.Core.Models;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Catalog.Services
{
    public class ProductService : IProductService
    {
        private readonly IStormyRepository<Product> _productRepository;                
        private readonly IStormyRepository<ProductCategory> _productCategoryRepository;        
        //TODO: I Think a service for this is unecessary        
        public ProductService(IStormyRepository<Product> productRepository,        
        IStormyRepository<ProductCategory> productCategoryRepository        
        )
        {
            _productRepository = productRepository;            
            _productCategoryRepository = productCategoryRepository;
            _productRepository.Query()
                .Include(prop => prop.Categories)
                    .ThenInclude(prop => prop.Category)
                .Include(prop => prop.Medias)
                    .ThenInclude(productMedia => productMedia.Media)
                .Include(prop => prop.Brand)                
                .Load();
        }
        #region Read Methods
        //TODO:write failing test cases
        public async Task<Result<IList<Product>>> GetAllProductsByCategory(int categoryId, int limit = 15)
        {
            return Result.Ok<IList<Product>>(await _productCategoryRepository.Query()
                .Where(prop => prop.CategoryId == categoryId)
                .Select(prop => prop.Product)
                .ToListAsync());
        }
        public async Task<IList<Product>> GetAllProductsDisplayedOnHomepageAsync(int limit)
        {
            return await _productRepository
                .Query()
                .OrderBy(p => p.Id)
                .Take(limit)
                .ToListAsync();
        }
        
        public async Task<IList<Product>> GetAllProductsAsync(long startIndex = 1, long endIndex = 15)
        {            
            return await _productRepository.Query()                
                .Where(product => product.Id <= endIndex && product.Id >= startIndex)                
                .ToListAsync();
        }

        public async Task<IList<Product>> GetAllProductsIncludingAsync(long startIndex = 1, long endIndex = 15)
        {
            return await _productRepository.Query()
                .Include(product => product.Brand)
                .Include(product => product.Categories)
                .Include(product => product.ProductLinks)
                .Include(product => product.Medias)                    
                .Include(product => product.OptionValues)                
                .Where(product => product.Id >= startIndex && product.Id <= endIndex)
                .ToListAsync();
            //.Include(product => product.)
        }
        public int GetNumberOfProducts()
        {
            return _productRepository.Query().Count();
        }
        public int GetNumberOfProductsByVendorId(int vendorId)
        {
            return _productRepository.Query().Where(f => f.VendorId == vendorId).Count();
        }

        public int GetNumberOfProductsInCategory(IList<long> categoryIds = null)
        {
            if (categoryIds == null) return 0;

            var products = new List<Product>();
            foreach (int id in categoryIds)
            {
                products = _productRepository.Query().Where(p => !(p.Categories.FirstOrDefault(c => c.Id == id) == null)).ToList();
            }

            return products.Count;
        }

        public async Task<Product> GetProductByIdAsync(long productId)
        {
            return await _productRepository.Query()
            .Include(p => p.Brand)
            .Include(p => p.Categories)
                .ThenInclude(p => p.Category)            
            .Include(p => p.Medias)
                .ThenInclude(p => p.Media)
            .Where(p => p.Id == productId)
            .FirstAsync();
        }
        public async Task<List<Product>> SearchProductsBySearchPattern(string searchPattern)
        {
            return await _productRepository.Query()
                .Where(p => EF.Functions.Like(p.ProductName.ToLower(), "%" + searchPattern.ToLower() + "%"))
                .ToListAsync();
        }
        public async Task<Product> GetProductBySkuAsync(string sku)
        {
            return await _productRepository.Query()
            .Where(p => p.Sku.Equals(sku, StringComparison.OrdinalIgnoreCase))
            .FirstAsync();
        }

        public async Task<IList<Product>> GetProductsByIdsAsync(long[] productIds)
        {
            return await _productRepository.GetAllByIdsAsync(productIds);
        }
        public Task<Product> GetProductByNameAsync(string productName)
        {
            return _productRepository.Query().Where(p => String.Equals(p.ProductName.Trim(), productName.Trim(), StringComparison.OrdinalIgnoreCase)).FirstOrDefaultAsync();
        }
        public async Task<IList<Product>> GetProductsBySkuAsync(string[] skuArray, int vendorId = 0)
        {
            return await _productRepository.Query().Where(p => skuArray.Contains(p.Sku)).ToListAsync();            
        }

        public int GetTotalStockQuantity()
        {
            return _productRepository.Query().Sum(f => f.UnitsInStock);
        }
        public int GetTotalStockQuantityOfProduct(long productId)
        {
            return _productRepository.Query()
                .Where(p => p.Id == productId)
                .Sum(p => p.UnitsInStock);
        }
        public int GetTotalStockQuantityOfProduct(Product product)
        {
            return _productRepository
                 .Query()
                 .Where(p => p.VendorId == product.VendorId)
                 .Sum(p => p.UnitsInStock);
        }        
        #endregion
        #region Delete methods
        public async Task DeleteProduct(Product product)
        {
            product.IsDeleted = true;
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProducts(IList<Product> products)
        {
            products.ToList().ForEach(p => p.IsDeleted = true);
            await UpdateProductsAsync(products);
        }
        public async Task DeleteProductAsync(Product product)
        {
            var entry = await _productRepository.GetByIdAsync(product.Id) ?? throw new ArgumentNullException("product don't exist");
            try{
                _productRepository.Delete(entry);
            } catch(Exception ex){                
                throw ex; 
            }

        }
        public Task DeleteProductsAsync(IList<Product> products)
        {
            throw new NotImplementedException();
        }
        #endregion                
        #region Insert Methods        
        public async Task InsertProductAsync(Product product)
        {            
            product.Slug = product.ProductName.Replace(' ','-');           
            if(product.BrandId != 0) product.Brand = null;                                        
            
            await _productRepository.AddAsync(product);                        
        }

        public async Task InsertProductsAsync(IList<Product> products)
        {
            await _productRepository.AddCollectionAsync(products);
        }
        #endregion
        #region Update Methods
        public async Task UpdateProductAsync(Product product)
        {            
            await _productRepository.UpdateAsync(product);
        }

        public async Task UpdateProductsAsync(IList<Product> products)
        {
            await _productRepository.UpdateCollectionAsync(products);
        }

        
        #endregion
        private bool IsSlugValid(Product product,string brandName,string categoryName)
        {
            return product.ProductName.Contains(brandName) && product.ProductName.Contains(categoryName);
        }

        
    }
}
