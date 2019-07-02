using StormyCommerce.Core.Entities.Catalog.Product;

namespace StormyCommerce.Core.Interfaces.Domain.Catalog
{
    //using to avoid problems for now, planning to refactor this(or rewrite)
    public interface IProductTemplateProductAttributeRepository
    {
        void Remove(ProductTemplateProductAttribute item);
    }
}