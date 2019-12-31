using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Api.Framework.Filters;

using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Module.Catalog.Interfaces;
using StormyCommerce.Module.Customer.Models;

namespace StormyCommerce.Module.Catalog.Controllers
{
    [Area("Catalog")]
    [ApiController]
    [Route("api/[Controller]")]
    [Authorize(Roles.Admin)]
    [EnableCors("Default")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;   
        }
        [HttpPost("create")]
        [ValidateModel]
        public async Task<IActionResult> CreateBrand([FromBody]Brand brand)
        {            
            await _brandService.AddAsync(brand);
            return Ok(Result.Ok());
        }
        [HttpGet("get")]        
        public async Task<Brand> GetBrandById(int id)
        {
            return await _brandService.GetBrandByIdAsync(id);
        }
        [HttpGet("list")]        
        public async Task<IList<Brand>> GetAllBrand()
        {
            return await _brandService.GetAllBrandsAsync();
        }
    }
}
