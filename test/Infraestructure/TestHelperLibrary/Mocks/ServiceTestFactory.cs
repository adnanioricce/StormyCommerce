using AutoMapper;
using Moq;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Services.Customer;
using StormyCommerce.Infraestructure.Data.Repositories;
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

        public static CustomerService GetCustomerService(bool seeded = false)
        {
            var context = DbContextHelper.GetDbContext();
            context.AddRange(Seeders.StormyCustomerSeed(10));
            context.SaveChanges();
            var reviews = Seeders.ReviewSeed(10);
            var addresses = Seeders.AddressSeed(5);
            reviews.ForEach(f => f.StormyCustomerId = 1);
            addresses.ForEach(f => f.OwnerId = 1);
            context.AddRange(reviews);
            context.SaveChanges();
            context.AddRange(addresses);
            context.SaveChanges();
            var reviewRepository = new StormyRepository<Review>(context);
            var customerRepository = new StormyRepository<StormyCustomer>(context);
            return new CustomerService(reviewRepository, customerRepository);
        }

        public static IMapper GetFakeMapper()
        {
            return new Mock<IMapper>().Object;
        }
    }
}
