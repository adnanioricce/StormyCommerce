using StormyCommerce.Core.Interfaces.Infraestructure.Data;
using System;
using System.Threading.Tasks;

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

        public Task UpdateAsync(ProductTemplateProductAttribute item)
        {
            throw new NotImplementedException();
        }
    }
}
