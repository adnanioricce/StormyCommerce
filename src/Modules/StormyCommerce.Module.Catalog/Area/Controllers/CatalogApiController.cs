using System.Threading.Tasks;
using StormyCommerce.Api.Framework.Controllers;
using StormyCommerce.Core.Services;
using AutoMapper;
using StormyCommerce.Core.Entities.Catalog.Product;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using System.Collections.Generic;
using StormyCommerce.Module.Catalog.Dtos;
using StormyCommerce.Core.Interfaces.Infraestructure;
using MediatR;
using StormyCommerce.Core.Notifications;

namespace StormyCommerce.Module.Catalog.Area.Controllers
{
	[Route("/catalog")]
	public class CatalogController : BaseApiController
	{
		private readonly IProductService productService;
		private readonly IMapper mapper;
        private readonly INotificationHandler<DomainNotification> notification;
        private readonly IMediatorHandler mediator;
        //TODO:Change the notification type

        public CatalogController(INotificationHandler<DomainNotification> notification,IMediatorHandler mediator,IProductService _productService, IMapper _mapper) : base(notification,mediator)
		{
			productService = _productService;
			mapper = _mapper;			
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
