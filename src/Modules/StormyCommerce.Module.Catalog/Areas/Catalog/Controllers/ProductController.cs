using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Module.Customer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Entities.Media;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Vendor;
using StormyCommerce.Core.Models.Requests;
using Microsoft.EntityFrameworkCore;

//! Remember to make a security check here.
namespace StormyCommerce.Module.Catalog.Controllers
{
    [Area("Catalog")]
    [ApiController]
    [Route("api/[Controller]")]    
    [EnableCors("Default")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;      
        private readonly IStormyRepository<ProductMedia> _productMediaRepository;  
        private readonly IStormyRepository<Category> _categoryRepository;  
        private readonly IStormyRepository<StormyVendor> _vendorRepository;  
        private readonly IStormyRepository<Brand> _brandRepository;  
        private readonly IStormyRepository<ProductCategory> _productCategoryRepository;
        private readonly IAppLogger<ProductController> _logger;
        private readonly IMapper _mapper;

        //TODO:Change the notification type
        public ProductController(IProductService productService,
        IStormyRepository<ProductMedia> productMediaRepository,
        IStormyRepository<Category> categoryRepository,
        IStormyRepository<StormyVendor> vendorRepository,
        IStormyRepository<Brand> brandRepository,
        IStormyRepository<ProductCategory> productCategoryRepository,
        IMapper mapper,
        IAppLogger<ProductController> logger)
        {
            _productService = productService;            
            _productMediaRepository = productMediaRepository;
            _categoryRepository = categoryRepository;
            _vendorRepository = vendorRepository;
            _brandRepository = brandRepository;
            _productCategoryRepository = productCategoryRepository;
            _mapper = mapper;
            _logger = logger;
        }
        [HttpGet("search")]
        [ValidateModel]
        [AllowAnonymous]
        [ProducesResponseType(typeof(ProductSearchResponse),200)]
        public async Task<Result<List<ProductSearchResponse>>> SearchProducts(string searchPattern)
        {
            var products = await _productService.SearchProductsBySearchPattern(searchPattern);
            var mappedProduct = _mapper.Map<List<StormyProduct>,List<ProductSearchResponse>>(products);
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
            return _mapper.Map<StormyProduct, ProductOverviewDto>(product);
        }

        [HttpGet("list")]
        [ValidateModel]
        [AllowAnonymous]
        //TODO:Check if request is from Admin
        public async Task<ActionResult<IList<ProductDto>>> GetAllProducts(long startIndex = 1, long endIndex = 15)
        {
            var products = await _productService.GetAllProductsAsync(startIndex, endIndex);
            if (products == null) return NotFound("Products not found");
            var result = _mapper.Map<IList<StormyProduct>, IList<ProductDto>>(products);
            return result.ToList();
        }

        [HttpGet("homepage")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<ActionResult<IList<ProductDto>>> GetAllProductsOnHomepage(int limit)
        {
            var products = await _productService.GetAllProductsDisplayedOnHomepageAsync(limit);

            if (products == null) return NotFound("Don't was possible to retrieve products");
            var mappedProducts = _mapper.Map<IList<StormyProduct>, IList<ProductDto>>(products);
            return mappedProducts.ToList();
        }

        [HttpGet("get")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<ActionResult<ProductDto>> GetProductById(long id)
        {
            var product = _mapper.Map<StormyProduct, ProductDto>(await _productService.GetProductByIdAsync(id));

            if (product == null) return NotFound("Don't was possible to get product");

            return product;
        }
        
        [HttpPost("create")]
        [ValidateModel]
        [Authorize(Roles.Admin)]
        public async Task<ActionResult> CreateProduct([FromBody]CreateProductRequest _model)
        {                                       
            var model = _mapper.Map<StormyProduct>(_model);
                                                     
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
        
        [HttpPut("edit")]
        [ValidateModel]
        [Authorize(Roles.Admin)]
        public async Task<IActionResult> EditProduct([FromBody]StormyProduct _model)
        {                        
            try{                 
                await _productService.UpdateProductAsync(_model);
            }catch(Exception ex){
                _logger.LogStackTrace(ex.Message,ex);
                throw ex;
            }
            return Ok();            
        }

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
            return _mapper.Map<IList<StormyProduct>, IList<ProductDto>>(model.Value);
        }
    }
}
