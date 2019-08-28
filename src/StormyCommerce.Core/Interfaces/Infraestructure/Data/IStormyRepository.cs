using StormyCommerce.Core.Entities; 
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Storage;

namespace StormyCommerce.Core.Interfaces
{
	public interface IStormyRepository<T> where T : BaseEntity
	{
		Task<IList<T>> GetAllAsync();
        Task<IList<T>> GetAllByIdsAsync(long[] ids);
		Task<T> GetByIdAsync(long id);
        Task UpdateAsync(T entity); 
		Task UpdateCollectionAsync(IEnumerable<T> entities);
		void Delete(T entity); 
		void DeleteCollection(IEnumerable<T> entities);	
		Task AddAsync(T entity); 
		Task AddCollectionAsync(IEnumerable<T> entities);			
		IQueryable<T> Table {get;}
		IDbContextTransaction BeginTransaction(); 
	}
}
