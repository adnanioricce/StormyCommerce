using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Controllers;
using StormyCommerce.Api.Framework.Dtos;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using StormyCommerce.Api.Framework.Filters;
namespace StormyCommerce.Module.Catalog.Area.Controllers
{
    public class CategoryController : BaseApiController
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IList<CategoryDto>>> GetAll()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();

            return Ok(_mapper.Map<IList<Category>, IList<CategoryDto>>(categories));
        }
        [HttpGet("{id}")]
        [ValidateModel]
        public async Task<ActionResult<CategoryDto>> GetCategoryById(long id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            if (category == null)
                return BadRequest("Don't was possible Category");

            return Ok(category);
        }        
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateModel]
        public async Task<IActionResult> CreateCategory(CategoryDto categoryDto)
        {
            //TODO:Add validations
            //TODO:Add Generic Response Type
            await _categoryService.AddAsync(_mapper.Map<CategoryDto, Category>(categoryDto));
            return Ok("Category Created");
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "admin")]
        [ValidateModel]
        public async Task<IActionResult> EditCategory(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            await _categoryService.UpdateAsync(category);
            return Ok("Updated With Sucess");            
        }
    }
}
