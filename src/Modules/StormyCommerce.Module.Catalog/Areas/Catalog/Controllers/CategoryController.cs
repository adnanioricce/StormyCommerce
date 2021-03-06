﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Filters;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Module.Customer.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Catalog.Controllers
{
    [Area("Catalog")]
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    [EnableCors("Default")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IAppLogger<CategoryController> _logger;
        public CategoryController(ICategoryService categoryService, IMapper mapper,IAppLogger<CategoryController> logger)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            _logger = logger;
        }

        ///<summary>
        /// Get all existing categories
        ///</summary>
        [HttpGet("list")]
        [AllowAnonymous]
        public async Task<ActionResult<IList<CategoryDto>>> GetAll()
        {
            var categories = _mapper.Map<IList<Category>, IList<CategoryDto>>(await _categoryService.GetAllCategoriesAsync());
            return categories.ToList();
        }

        [HttpGet]
        [ValidateModel]
        [AllowAnonymous]
        public async Task<ActionResult<CategoryDto>> GetCategoryById(long id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            if (category == null)
                return BadRequest("Don't was possible get Category,Id don't exist");

            return _mapper.Map<Category, CategoryDto>(category);
        }

        [HttpPost("create")]
        [Authorize("Admin")]
        [ValidateModel]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            //TODO:Add validations
            //TODO:Add Generic Response Type
            HttpContext.Request.Headers.ToList().ForEach(h => {
                _logger.LogInformation($"key:{h.Key},value:{h.Value}");
            });
            await _categoryService.AddAsync(category);
            return Ok("Category Created");
        }

        [HttpPut("edit")]
        [Authorize(Policy = Roles.Admin)]
        [ValidateModel]
        public async Task<IActionResult> EditCategory(Category category)
        {
            await _categoryService.UpdateAsync(category);
            return Ok(Result.Ok("Updated With Success"));
        }
    }
}
