using StormyCommerce.Core.Entities.Catalog.Product;
using System.Threading.Tasks;

namespace StormyCommerce.Core.Interfaces.Domain.Catalog
{
    //using to avoid problems for now, planning to refactor this(or rewrite)
    public interface IProductTemplateProductAttributeRepository
    {
        Task UpdateAsync(ProductTemplateProductAttribute item);
        void Remove(ProductTemplateProductAttribute item);
    }
}
