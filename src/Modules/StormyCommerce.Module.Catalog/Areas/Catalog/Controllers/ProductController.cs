using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure.Web.Filters;
using SimplCommerce.Infrastructure.Logging;
using StormyCommerce.Module.Catalog.Interfaces;
using SimplCommerce.Module.Core.Services;
using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Module.Catalog.Models.Dtos;
using StormyCommerce.Module.Catalog.Models.Requests;
using StormyCommerce.Module.Catalog.Models.Responses;
using SimplCommerce.Infrastructure;
namespace StormyCommerce.Module.Catalog.Controllers
{
    [Area("Catalog")]        
    [EnableCors("Default")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IStormyProductService _productService;              
        private readonly IAppLogger<ProductController> _logger;
        private readonly IMapper _mapper;
        private readonly IMediaService _mediaService;        
        public ProductController(IStormyProductService productService,        
            IMapper mapper,
            IMediaService mediaService,
            IAppLogger<ProductController> logger)
        {
            _productService = productService;
            _mediaService = mediaService;
            _mapper = mapper;
            _logger = logger;
        }
        [HttpGet("search")]
        [ValidateModel]
        [AllowAnonymous]        
        public async Task<Result<List<ProductSearchResponse>>> SearchProducts(string searchPattern)
        {
            var products = await _productService.SearchProductsBySearchPattern(searchPattern);
            var mappedProduct = _mapper.Map<List<Product>,List<ProductSearchResponse>>(products);
            return Result.Ok(mappedProduct);
        }        
        ///<summary>
        /// Get a more simplified version of a specified product
        ///</summary>
        [HttpGet("get_overview")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<ActionResult<ProductOverviewDto>> GetProductOverviewAsync(long id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            if (product == null) return NotFound("Requested product didn't exist");
            return _mapper.Map<Product, ProductOverviewDto>(product);
        }

        [HttpGet("list")]
        [ValidateModel]
        [AllowAnonymous]
        //TODO:Check if request is from Admin
        public async Task<ActionResult<IList<ProductDto>>> GetAllProducts(long startIndex = 1, long endIndex = 15)
        {
            var products = await _productService.GetAllProductsAsync(startIndex, endIndex);
            if (products == null) return NotFound("Products not found");
            var result = _mapper.Map<IList<Product>, IList<ProductDto>>(products);
            return result.ToList();
        }
        

        [HttpGet("get")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<ActionResult<ProductDto>> GetProductById(long id)
        {
            var product = _mapper.Map<Product, ProductDto>(await _productService.GetProductByIdAsync(id));

            if (product == null) return NotFound("Don't was possible to get product");

            return product;
        }
        [HttpGet("get_number_of_products")]        
        [AllowAnonymous]
        public int GetNumberOfProducts()
        {
            return _productService.GetNumberOfProducts();
        }
        #region Post Methods        

        [HttpPost("create")]
        [ValidateModel]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult> CreateProduct([FromBody]CreateProductRequest _model)
        {                                       
            var model = _mapper.Map<CreateProductRequest,Product>(_model);                                                                 
            try
            {                
                await _productService.InsertProductAsync(model);                                
            }                        
            catch(DbUpdateException ex){
                _logger.LogError($"don't was possible to create product, application returned the following exception:{ex}");
                return BadRequest($"application failed to perform given operation. Given exception:{ex.Message}");
            }
            return Ok();
        }             
        #endregion
        #region Put Methods
        [HttpPut("edit")]
        [ValidateModel]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> EditProduct([FromBody]EditProductRequest _model)
        {                        
            try
            {
                var entry = await _productService.GetProductByIdAsync(_model.Id);
                var product = _mapper.Map<EditProductRequest,Product>(_model,entry);
                await _productService.UpdateProductAsync(product);
            }catch(Exception ex){
                _logger.LogStackTrace(ex.Message,ex);
                throw ex;
            }
            return Ok();            
        }
        #endregion
        [HttpGet("getlength/category")]
        [ValidateModel]
        [AllowAnonymous]
        public ActionResult<int> GetNumberOfProductsInCategory(IList<long> categoryIds)
        {
            var model = _productService.GetNumberOfProductsInCategory(categoryIds);
            return model;
        }

        [HttpGet("list/category")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<IList<ProductDto>> GetAllProductsOnCategory(int categoryId, int limit)
        {
            var model = await _productService.GetAllProductsByCategory(categoryId, limit);
            return _mapper.Map<IList<Product>, IList<ProductDto>>(model.Value);
        }
        
        
    }
}
