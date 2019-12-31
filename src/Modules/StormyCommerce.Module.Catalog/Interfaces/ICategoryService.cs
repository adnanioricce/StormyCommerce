using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Catalog.Interfaces
{
    public interface ICategoryService
    {
        //TODO:Get Categories by category type
        Task<IList<Category>> GetAllCategoriesAsync();

        Task<Category> GetCategoryByIdAsync(long id);

        Task AddAsync(Category entity);

        Task<Result> UpdateAsync(Category entry);

        Task DeleteAsync(long id);

        Task DeleteAsync(Category entity);
    }
}
