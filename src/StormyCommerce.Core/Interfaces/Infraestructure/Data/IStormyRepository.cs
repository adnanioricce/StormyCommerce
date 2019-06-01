using StormyCommerce.Core.Entities; 
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace StormyCommerce.Core.Interfaces
{
	public interface IStormyRepository<T> where T : BaseEntity
	{
		Task<ICollection<T>> GetAllAsync();
        Task<ICollection<T>> GetAllByIdsAsync(int[] ids);
		Task<T> GetByIdAsync(int id);
        Task UpdateAsync(T entity); 
		Task UpdateCollectionAsync(IEnumerable<T> entities);
		void Delete(T entity); 
		void DeleteCollection(IEnumerable<T> entities);	
		Task AddAsync(T entity); 
		Task AddCollectionAsync(IEnumerable<T> entities);			
		IQueryable<T> Table {get;}		
	}
}
