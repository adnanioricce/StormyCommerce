using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Models;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Domain.Catalog
{
    public interface IProductTemplateService
    {
        Task<Result<ProductTemplate>> GetProductTemplateByIdAsync(long id);

        Task<Result> CreateProductTemplateAsync(ProductTemplate productTemplate);

        Task<Result> EditProductTemplateAsync(long id, ProductTemplate productTemplate);
    }
}
