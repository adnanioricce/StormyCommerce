using System;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces.Domain.Catalog;
using StormyCommerce.Core.Interfaces.Infraestructure.Data;

namespace StormyCommerce.Core.Repositories
{
    public class ProductTemplateProductAttributeRepository : IProductTemplateProductAttributeRepository
    {
        private readonly IStormyDbContext _dbContext;
        public ProductTemplateProductAttributeRepository(IStormyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Remove(ProductTemplateProductAttribute item)
        {
            // _dbContext.Set<ProductTemplateProductAttribute>().Remove(item);
            throw new NotImplementedException();
        }
    }
}