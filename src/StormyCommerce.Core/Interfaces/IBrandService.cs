using System.Collections.Generic;
using System.Threading.Tasks;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Core.Interfaces
{
	//!Why? This seem like a duplicate logic 
	//I'll keep to avoid breaking something
	public interface IBrandService
	{
        Task<Brand> GetBrandByIdAsync(long id);
        Task<IList<Brand>> GetAllBrandsAsync();
        Task AddAsync(Brand entity);
		Task UpdateAsync(Brand entity); 
		Task DeleteAsync(long id); 
		Task DeleteAsync(Brand entity);
	}
}
