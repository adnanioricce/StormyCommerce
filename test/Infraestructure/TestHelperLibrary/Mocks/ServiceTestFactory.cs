using AutoMapper;
using Moq;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Services.Catalog;
using TestHelperLibrary.Utils;

namespace TestHelperLibrary.Mocks
{
    public static class ServiceTestFactory
    {
        public static ProductService GetProductService()
        {
            return new ProductService(RepositoryHelper.GetRepository<StormyProduct>());
        }

        public static CategoryService GetCategoryService()
        {
            return new CategoryService(RepositoryHelper.GetRepository<Category>(), GetEntityService());
        }

        public static EntityService GetEntityService()
        {
            return new EntityService(RepositoryHelper.GetRepository<Entity>());
        }

        public static IMapper GetFakeMapper()
        {
            return new Mock<IMapper>().Object;
        }
    }
}
