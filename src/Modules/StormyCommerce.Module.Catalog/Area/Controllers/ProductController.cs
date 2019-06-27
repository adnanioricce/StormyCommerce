using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Controllers;
using StormyCommerce.Api.Framework.Dtos;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Catalog.Area.Controllers
{	
	public class ProductController : BaseApiController
	{
		private readonly IProductService _productService;
		private readonly IMapper _mapper;
        //TODO:Change the notification type

        public ProductController(IProductService productService, IMapper mapper) 
		{
			_productService = productService;
			_mapper = mapper;			
		}
		public async Task<ActionResult<ProductOverviewDto>> GetProductOverviewAsync(long id)
		{
            var product = await _productService.GetProductByIdAsync(id);
            if (product == null)
                return BadRequest("Requested product didn't exist");

            return Ok(_mapper.Map<StormyProduct, ProductOverviewDto>(product));
        }
		[HttpGet]
		public async Task<ActionResult<IList<ProductDto>>> GetAllProductsOnHomepage(int limit)
		{
            var products = await _productService.GetAllProductsDisplayedOnHomepageAsync(limit);
            if (products == null)
                return BadRequest("Don't was possible to retrieve products");

            return Ok(_mapper.Map<IList<StormyProduct>, IList<ProductDto>>(products));
		}
		[HttpGet("catalog/product/{0}")]
		public async Task<ActionResult<ProductDto>> GetProductById(long id)
		{
            var product = await _productService.GetProductByIdAsync(id);
            if (product == null)
                return BadRequest("Don't was possible to get product");

            return Ok(_mapper.Map<StormyProduct, ProductDto>(product));
		}
		[HttpPost("catalog/product/create")]
		public async Task CreateProduct(ProductDto _model)
		{
			var model = _mapper.Map<StormyProduct>( _model);
			await _productService.InsertProductAsync(model);
		}
	}
}
