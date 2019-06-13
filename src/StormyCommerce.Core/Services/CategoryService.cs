using System.Collections.Generic; 
using System.Threading.Tasks; 
using System.Linq;
using System;
namespace StormyCommerce.Core.Services
{
	public class CategoryService : ICategoryService
	{
		private const string entityTypeId = "Category";
		private readonly IStormyRepository<Category> categoryRepository;
		private readonly IEntityService entityService;
		public CategoryService(IStormyRepository<Category> _categoryRepository,IEntityService _entityService)
		{
			categoryService = _categoryRepository;
			entityService = _entityService;
		}
		public async Task<IList<Category>> GetAllAsync()
		{
			return await categoryRepository.Table.ToList();
		}
		//!INCOMPLETE METHOD
		public async Task AddAsync(Category entity)
		{
			entity.Slug = entityService.ToSafeSlug(entity.Slug,entity.Id,entityTypeId);
			await categoryService.AddAsync(entity);
		}
		public Task UpdateAsync(Category entity)
		{
			entity.Slug = entityService.ToSafeSlug(entity.Slug,entity.Id,entityTypeId);
			entityService.Update(entity.Name,entity.Slug,entity.Id,entityTypeId);

		} 
		public Task DeleteAsync(long id)
		{
			throw new NotImplementedException();
		}
		public Task DeleteAsync(Category entity)
		{
			throw new NotImplementedException();
		}

	}
}
