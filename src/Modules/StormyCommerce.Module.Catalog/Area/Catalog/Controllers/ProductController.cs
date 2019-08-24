using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//! Remember to make a security check here.
namespace StormyCommerce.Module.Catalog.Area.Controllers
{
    [Area("Catalog")]
    [ApiController]
    [Route("api/[Controller]/[Action]")]
    public class ProductController : Controller
	{
		private readonly IProductService _productService;
		private readonly IMapper _mapper;
        
        //TODO:Change the notification type
        public ProductController(IProductService productService, IMapper mapper) 
		{
			_productService = productService;
			_mapper = mapper;			
		}
        [HttpGet("product/product-overview/{0}")]
		[ValidateModel]
		public async Task<ActionResult<ProductOverviewDto>> GetProductOverviewAsync(long id)
		{
            var product = await _productService.GetProductByIdAsync(id);			
            if (product == null) return BadRequest("Requested product didn't exist");

            return _mapper.Map<StormyProduct, ProductOverviewDto>(product);
        }
		[HttpGet("admin/product/list")]
		[ValidateModel]
		//TODO:Check if request is from Admin
		public async Task<ActionResult<IList<ProductDto>>> GetAllProducts(long startIndex = 1,long endIndex = 15)
		{			
			var products = await _productService.GetAllProductsAsync(startIndex,endIndex);
            
			if (products == null) return NotFound("Products not found");

            var result = _mapper.Map<IList<StormyProduct>, IList<ProductDto>>(products);            

            return result.ToList();
		}
		[HttpGet("product/homepage")]
		[ValidateModel]
		public async Task<ActionResult<IList<ProductDto>>> GetAllProductsOnHomepage(int limit)
		{
            var products = await _productService.GetAllProductsDisplayedOnHomepageAsync(limit);		
            
            if (products == null) return BadRequest("Don't was possible to retrieve products");
            var mappedProducts = _mapper.Map<IList<StormyProduct>, IList<ProductDto>>(products);
            return mappedProducts.ToList();
		}
		[HttpGet("product/{0}")]
		[ValidateModel]
		public async Task<ActionResult<ProductDto>> GetProductById(long id)
		{
            var product = _mapper.Map<StormyProduct,ProductDto>(await _productService.GetProductByIdAsync(id));

            if (product == null) return BadRequest("Don't was possible to get product");

            return product;
		}
		[HttpPost("product/create")]
		[ValidateModel]
		public async Task<ActionResult> CreateProduct([FromBody]ProductDto _model)
		{
            //var model = _mapper.Map<StormyProduct>( _model);
            var model = new StormyProduct(_model);
			await _productService.InsertProductAsync(model);
            return Ok();
		}
		[HttpPut("product/edit")]
		[ValidateModel]
		public async Task EditProduct([FromBody]ProductDto _model)
		{
			var model = _mapper.Map<StormyProduct>(_model);
			//var result = await _productService.UpdateProductAsync(model);
			//if(!result.Success){
			//	return Result.Ok();
			//}

		}
		[HttpGet("product/number_products_in_category")]
		[ValidateModel]
		public ActionResult<int> GetNumberOfProductsInCategory([FromBody]IList<int> categoryIds,int storeId)
		{
			var model = _productService.GetNumberOfProductsInCategory(categoryIds,storeId);
			return model;
		}
		[HttpGet]
		[ValidateModel]
		public async Task<IList<ProductDto>> GetAllProductsOnCategory(int categoryId,int limit)
		{
			var model = await _productService.GetAllProductsByCategory(categoryId,limit);
			return _mapper.Map<IList<StormyProduct>,IList<ProductDto>>(model.Value);
		}				
	}
}
