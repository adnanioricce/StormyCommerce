using Moq;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Tests.Helpers;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests
{
    public class BrandServiceTest
    {
        public Mock<IEntityService> fakeEntityService { get; }
        private readonly IStormyRepository<Brand> _repository;
        private readonly IBrandService _service;

        public BrandServiceTest()
        {
            fakeEntityService = new Mock<IEntityService>();
            fakeEntityService.Setup(x => x.ToSafeSlug(It.IsAny<string>(), It.IsAny<long>(), It.IsAny<string>())).Returns("fake-slug");
            _repository = RepositoryHelper.GetRepository<Brand>();
            _repository.AddCollectionAsync(Seeders.BrandSeed(2));
            Task.WaitAll();
            _service = new BrandService(_repository, fakeEntityService.Object);
        }

        [Fact]
        public async Task AddBrandEntityAsync_WithValidEntry_ShouldCreateEntryOnDatabase()
        {
            //When
            await _service.AddAsync(BrandDataSeeder.GetSampleData());
            var entity = await _service.GetBrandByIdAsync(3);
            //Then
            Assert.Equal(3, entity.Id);
        }

        [Fact]
        public async Task DeleteBrandEntityAsync_ForExistingEntityAndValidInput_ShouldDeleteEntityFromDatabase()
        {
            //Given
            var brands = await _service.GetAllBrandsAsync();
            Assert.Equal(_repository.Table.Count(), brands.Count);
            //When
            await _service.DeleteAsync(1);
            brands = await _service.GetAllBrandsAsync();
            //Then
            Assert.Equal(_repository.Table.Count(), brands.Count);
        }

        [Fact]
        public async Task UpdateBrandEntityAsync_ToReplaceExistingEntityWithValidEntry_ShouldReplaceEntityWithProvided()
        {
            //Given
            var oldBrand = await _service.GetBrandByIdAsync(1);
            var newBrand = BrandDataSeeder.GetSingleBrandData();
            //When
            await _service.UpdateAsync(newBrand);
            var brand = await _repository.GetByIdAsync(1);
            //Then
            Assert.NotSame(brand, oldBrand);
            Assert.Equal(brand.Id, oldBrand.Id);
            Assert.NotEqual(oldBrand.Name, brand.Name);
            Assert.NotEqual(oldBrand.Slug, brand.Slug);
            Assert.NotEqual(oldBrand.Website, brand.Website);
            Assert.NotEqual(oldBrand.LastModified, brand.LastModified);
            Assert.NotEqual(oldBrand.Description, brand.Description);
        }
    }
}
