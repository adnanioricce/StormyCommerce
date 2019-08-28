using System.Threading.Tasks;
using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Core.Interfaces.Domain.Catalog
{
    public interface IProductTemplateService
    {
        Task<ProductTemplate> GetProductTemplateByIdAsync(long id);
        Task CreateProductTemplateAsync(ProductTemplate productTemplate);
        Task EditProductTemplateAsync(long id,ProductTemplate productTemplate);
    }    
}
