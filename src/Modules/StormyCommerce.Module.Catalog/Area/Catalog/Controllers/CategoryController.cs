using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using System.Linq;
using Microsoft.AspNetCore.Cors;

namespace StormyCommerce.Module.Catalog.Area.Controllers
{
    [Area("Catalog")]
    [ApiController]        
    [Authorize]
    [Route("api/[Controller]/[Action]")]
    [EnableCors("Default")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        ///<summary>
        /// Get all existing categories
        ///</summary>
        [HttpGet("list")]
        [AllowAnonymous]
        public async Task<ActionResult<IList<CategoryDto>>> GetAll()
        {            
            var categories = _mapper.Map<IList<Category>,IList<CategoryDto>>(await _categoryService.GetAllCategoriesAsync());
            return categories.ToList();
        }
        [HttpGet("{id}")]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<ActionResult<CategoryDto>> GetCategoryById(long id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            if (category == null)
                return BadRequest("Don't was possible get Category,Id don't exist");

            return _mapper.Map<Category,CategoryDto>(category);
        }        
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateModel]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            //TODO:Add validations
            //TODO:Add Generic Response Type            
            await _categoryService.AddAsync(category);
            return Ok("Category Created");
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "admin")]
        [ValidateModel]
        public async Task<IActionResult> EditCategory(Category category)
        {            
            await _categoryService.UpdateAsync(category);
            return Ok("Updated With Success");            
        }
    }
}
