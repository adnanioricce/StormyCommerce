using StormyCommerce.Core.Entities.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace StormyCommerce.Core.Interfaces
{
	public interface ICategoryService
	{
		//TODO:Get Categories by category type
		Task<IList<Category>> GetAllAsync();
		Task AddAsync(Category entity);
		Task UpdateAsync(Category entity); 
		Task DeleteAsync(long id); 
		Task DeleteAsync(Category entity);
	}
}
