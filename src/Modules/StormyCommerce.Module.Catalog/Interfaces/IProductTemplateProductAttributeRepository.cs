using SimplCommerce.Module.Catalog.Models;
using System.Threading.Tasks;

namespace StormyCommerce.Module.Catalog.Interfaces
{
    //using to avoid problems for now, planning to refactor this(or rewrite)
    public interface IProductTemplateProductAttributeRepository
    {
        Task UpdateAsync(ProductTemplateProductAttribute item);

        void Remove(ProductTemplateProductAttribute item);
    }
}
