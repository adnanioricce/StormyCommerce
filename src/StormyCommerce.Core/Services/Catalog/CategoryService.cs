using System.Collections.Generic; 
using System.Threading.Tasks; 
using System.Linq;
using System;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;
using StormyCommerce.Core.Entities.Catalog;
using Microsoft.EntityFrameworkCore;
using StormyCommerce.Core.Models;

namespace StormyCommerce.Core.Services.Catalog
{
	public class CategoryService : ICategoryService
	{
		private const string entityTypeId = "Category";
		private readonly IStormyRepository<Category> categoryRepository;
		private readonly IEntityService entityService;
		public CategoryService(IStormyRepository<Category> _categoryRepository,
		IEntityService _entityService)
		{
			categoryRepository = _categoryRepository;
			entityService = _entityService;
		}        
        public async Task<IList<Category>> GetAllCategoriesAsync()
		{
			return await categoryRepository.GetAllAsync();
		}
        public async Task<Category> GetCategoryByIdAsync(long id)
        {
            var category = await categoryRepository.GetByIdAsync(id);
            return category;
        }		
		public async Task AddAsync(Category entity)
		{
			entity.Slug = entityService.ToSafeSlug(entity.Slug,entity.Id,entityTypeId);
			await categoryRepository.AddAsync(entity);
		}
		public async Task<Result> UpdateAsync(Category entry)
		{
            if (entry == null)
            {
                var error = new Error("404", "given request is can't be null", new ArgumentNullException("request object is null"));
                return new Result<Error>(error, false, error.Description);
            }

            var category = await categoryRepository.GetByIdAsync(entry.Id);

            if (category == null)
            {
                var error = new Error("404", "Category don't exist", new ArgumentNullException("requested category is null"));
                return new Result<Error>(error,false,error.Description);
            }
            
            if (category.Equals(entry))
                return Result.Ok("data don't have modifications,no update performed");

            category = entry;
            category.Slug = entityService.ToSafeSlug(entry.Slug, entry.Id,entityTypeId);
			entityService.Update(category.Name, category.Slug, category.Id,entityTypeId);
            await categoryRepository.UpdateAsync(category);
            return Result.Ok();
		} 
		public async Task DeleteAsync(long id)
		{
            var category = await categoryRepository.GetByIdAsync(id);
            category.IsDeleted = true;
            await entityService.DeleteAsync(category.Id,entityTypeId);
            await categoryRepository.UpdateAsync(category);
		}
		public async Task DeleteAsync(Category entity)
		{
            var category = await categoryRepository.GetByIdAsync(entity.Id) ?? throw new NullReferenceException();
			await entityService.DeleteAsync(category.Id,entityTypeId);
            categoryRepository.Delete(entity);
		}

	}
}
