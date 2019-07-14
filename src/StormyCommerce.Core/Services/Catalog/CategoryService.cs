using System.Collections.Generic; 
using System.Threading.Tasks; 
using System.Linq;
using System;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;
using StormyCommerce.Core.Entities.Catalog;
using Microsoft.EntityFrameworkCore;

namespace StormyCommerce.Core.Services.Catalog
{
	public class CategoryService : ICategoryService
	{
		private const string entityTypeId = "Category";
		private readonly IStormyRepository<Category> categoryRepository;
		private readonly IEntityService entityService;
		public CategoryService(IStormyRepository<Category> _categoryRepository,IEntityService _entityService)
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
		public async Task UpdateAsync(Category entity)
		{
			entity.Slug = entityService.ToSafeSlug(entity.Slug,entity.Id,entityTypeId);
			entityService.Update(entity.Name,entity.Slug,entity.Id,entityTypeId);
			await categoryRepository.UpdateAsync(entity);
		} 
		public async Task DeleteAsync(long id)
		{
            var category = await categoryRepository.GetByIdAsync(id);
            category.IsDeleted = true;
            await entityService.DeleteAsync(category.Id,entityTypeId);
            categoryRepository.Delete(category);
		}
		public async Task DeleteAsync(Category entity)
		{
            var category = await categoryRepository.GetByIdAsync(entity.Id) ?? throw new NullReferenceException();
			await entityService.DeleteAsync(category.Id,entityTypeId);
            categoryRepository.Delete(entity);
		}

	}
}
