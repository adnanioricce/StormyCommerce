using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Core.Models;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Catalog.Interfaces
{
    public interface IProductTemplateService
    {
        Task<Result<ProductTemplate>> GetProductTemplateByIdAsync(long id);

        Task<Result> CreateProductTemplateAsync(ProductTemplate productTemplate);

        Task<Result> EditProductTemplateAsync(long id, ProductTemplate productTemplate);
    }
}
