using System.Threading.Tasks;
using StormyCommerce.Api.Framework.Controllers;
using StormyCommerce.Core.Services;
using AutoMapper;
namespace StormyCommerce.Module.Catalog.Area.Controllers
{
	[Route("/catalog")]
	public class CatalogController : BaseApiController
	{
		private readonly IProductService productService;
		private readonly IMapper mapper;
		public CatalogController(IProductService _productService,IMapper _mapper)
		{
			productService = _productService;
			mapper = _mapper;			
		}
		[HttpGet]
		public async Task<IList<ProductDto>> GetAllProductsOnHomepage(int limit)
		{
			return await productService.GetAllProductsDisplayedOnHomepageAsync(limit);
		}
		[HttpGet("catalog/product/{0}")]
		public async Task<ProductDto> GetProduct(GetProductRequest _model)
		{
			var model = mapper<StormyProduct>(_model);
			return await mapper<ProductDto>(productService.GetProductById(model.Id));
		}
		[HttpPost("catalog/product/create")]
		public async Task<SomeReturnType> CreateProduct(CreateProductRequest _model)
		{
			return await productService.InsertAsync(mapper<StormyProduct>(_model));
		}
	}
}
