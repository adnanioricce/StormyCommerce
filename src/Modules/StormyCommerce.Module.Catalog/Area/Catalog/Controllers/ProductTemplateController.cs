using AutoMapper;
using StormyCommerce.Api.Framework.Controllers;
using StormyCommerce.Core.Interfaces.Domain.Catalog;

namespace StormyCommerce.Module.Catalog.Area.Controllers
{
    public class ProductTemplateController : BaseApiController
    {
        private readonly IProductTemplateService _productTemplateService;
        private readonly IMapper _mapper;
        public ProductTemplateController(IProductTemplateService productTemplateService,
        IMapper mapper)
        {
            _productTemplateService = productTemplateService;
            _mapper = mapper;
        }                
    }
}
