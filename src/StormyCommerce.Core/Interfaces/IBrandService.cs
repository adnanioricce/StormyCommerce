using System.Threading.Tasks;
using StormyCommerce.Core.Entities.Catalog;
namespace StormyCommerce.Core.Interfaces
{
	//!Why? This seem like a duplicate logic 
	//I'll keep to avoid breaking something
	public interface IBrandService
	{
		Task AddAsync(Brand entity);
		Task UpdateAsync(Brand entity); 
		Task DeleteAsync(int id); 
		Task DeleteAsync(Brand entity);
	}
}
