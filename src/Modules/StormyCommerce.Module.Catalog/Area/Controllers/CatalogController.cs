namespace StormyCommerce.Module.Catalog.Area.Controllers
{
	[Route("[Controller]")]
	public class CatalogController
	{
		private readonly IProductService productService;
		private readonly IMapper mapper;
        	//TODO:Change the notification type

        	public CatalogController(IProductService _productService, IMapper _mapper) 
		{
			productService = _productService;
			mapper = _mapper;			
		}
		public async Task<ProductOverviewDto> GetProductOverviewAsync(long id)
		{
			pro
		}
		[HttpGet]
		public async Task<IList<ProductDto>> GetAllProductsOnHomepage(int limit)
		{
			return mapper.Map<IList<StormyProduct>,IList<ProductDto>>(await productService.GetAllProductsDisplayedOnHomepageAsync(limit));
		}
		[HttpGet("catalog/product/{0}")]
		public async Task<ProductDto> GetProduct(DomainNotification _model)
		{
			var model = mapper.Map<StormyProduct>(_model);
			return mapper.Map<StormyProduct, ProductDto>(await productService.GetProductByIdAsync(model.Id));
		}
		[HttpPost("catalog/product/create")]
		public async Task CreateProduct(DomainNotification _model)
		{
			var model = mapper.Map<StormyProduct>( _model);
			await productService.InsertProductAsync(model);
		}

	}
}
