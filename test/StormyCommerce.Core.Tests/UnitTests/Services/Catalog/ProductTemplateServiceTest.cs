using System.Threading.Tasks;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Repositories;
using StormyCommerce.Core.Services.Catalog;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests.Services.Catalog
{
    public class ProductTemplateServiceTest
    {
        private ProductTemplateService CreateService()
        {
            return new ProductTemplateService(RepositoryHelper.GetRepository<ProductTemplate>(),RepositoryHelper.GetRepository<ProductAttribute>(),new ProductTemplateProductAttributeRepository(DbContextHelper.GetDbContext()));
        }
        [Fact]
        public async Task CreateProductTemplateAsync_ReceivesProductTemplateEntity_CreateNewProductTemplateOnDatabase()
        {
            //Given
            var productTemplate = new ProductTemplate{

            };
            var service = CreateService();
            //When
            var result = await service.CreateProductTemplateAsync(productTemplate);
            var entry = await service.GetProductTemplateByIdAsync(1);
            //Then
            Assert.Equal(result.Success,true);
            Assert.Equal(productTemplate.Id,entry.Value.Id);
            Assert.Equal(productTemplate.ProductAttributes,entry.Value.ProductAttributes);
        }
        [Fact]
        public async Task GetProductTemplateByIdAsync_ReceivesLongValue_ShouldReturnEntityWithIdEqualLongValue()
        {
            //Given
            long id = 1;
            var service = CreateService();
            //When
            
            //Then
        }
    }
}