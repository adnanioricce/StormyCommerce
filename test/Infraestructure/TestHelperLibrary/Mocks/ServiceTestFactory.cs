using AutoMapper;
using Moq;
using SimplCommerce.Module.Catalog.Models;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Module.Catalog.Services;
using TestHelperLibrary.Utils;

namespace TestHelperLibrary.Mocks
{
    public static class ServiceTestFactory
    {
        public static ProductService GetProductService()
        {
            return new ProductService(RepositoryHelper.GetRepository<Product>(),            
            RepositoryHelper.GetRepository<ProductCategory>());
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
