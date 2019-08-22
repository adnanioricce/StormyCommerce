using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Core.Interfaces.Domain.Catalog;

namespace StormyCommerce.Module.Catalog.Area.Controllers
{
    //TODO:CMS? This don't seem thing from here
    [Area("Catalog")]
    [ApiController]
    [Route("api/[Controller]/[Action]")]
    public class ProductTemplateController : Controller
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
