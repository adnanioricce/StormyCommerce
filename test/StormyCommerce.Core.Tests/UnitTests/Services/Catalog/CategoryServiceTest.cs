using Moq;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Interfaces.Domain;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Core.Tests.Helpers;
using StormyCommerce.Infraestructure.Data;
using StormyCommerce.Infraestructure.Data.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.UnitTests
{
    public class CategoryServiceTest
    {
        public Mock<IEntityService> FakeEntityService { get; set; }
        private readonly ICategoryService _service;
        private readonly IStormyRepository<Category> _repository;
        public CategoryServiceTest()
        {
            FakeEntityService = new Mock<IEntityService>();
            FakeEntityService.Setup(x => x.Add(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<long>(), It.IsAny<string>()))
                .Callback(() => Console.WriteLine("fake callback delegate log(add method)"));
            FakeEntityService.Setup(x => x.Update(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<long>(), It.IsAny<string>()))
                .Callback(() => Console.WriteLine("fake callback delegate log(update method)"));
            FakeEntityService.Setup(x => x.ToSafeSlug(It.IsAny<string>(), It.IsAny<long>(), It.IsAny<string>())).Returns("fake-slug");
            _repository = RepositoryHelper.GetRepository<Category>();
            _repository.AddCollectionAsync(Seeders.CategorySeed(5));
            Task.WaitAll();
            _service = new CategoryService(_repository,FakeEntityService.Object);
        }
        [Fact]
        public async Task GetCategoryByIdAsync_WithValidInputForExistingEntity_ShouldReturnCorrespondentEntity()
        {         
            //Arrange
            //var repo = RepositoryHelper.GetRepository<Category>();
            //await repo.AddAsync(Seeders.CategorySeed(1).First());                                
            //var service = new CategoryService(repo,null);
            //Act
            var entity = await _service.GetCategoryByIdAsync(1);
            //Assert
            Assert.Equal(1, entity.Id);
            
        }
        [Fact]
        public async Task GetAllCategoriesAsync_NoInput_ShouldReturnAllNonDeletedEntitiesOnDatabase()
        {            
            //Arrange
            //var repo = RepositoryHelper.GetRepository<Category>();                                         
            //var service = new CategoryService(repo, null);
            //Act
            var entities = await _service.GetAllCategoriesAsync();
            //Assert
            Assert.Equal(_repository.Table.Count(),entities.Count);                            
        }                 
        [Fact]
        public async Task AddCategoryAsync_WithValidEntry_ShouldCreateNewEntryOnDatabase()
        {
            //Given                
            //var repo = RepositoryHelper.GetRepository<Category>();            
            //var service = new CategoryService(repo,FakeEntityService.Object);                
            //When
            var category = Seeders.CategorySeed(1).First();
            category.Id = 6;
            await _service.AddAsync(category);            
            var entry = await _repository.GetByIdAsync(6);
            //Then
            Assert.Equal(6, entry.Id);                            
        }

        [Fact]
        public async Task UpdateCategoryAsync_WithValidEntityAndExistingEntity_ShouldReplaceOldEntityByProvidedEntity()
        {            
            //Arrange            
            var oldCategory = await _service.GetCategoryByIdAsync(1);
            var newCategory = new Category(oldCategory);
            newCategory.Description = "Updated Description";
            //When 
            await _service.UpdateAsync(newCategory);
            var currentCategory = await _service.GetCategoryByIdAsync(1);
            //Then                 
            Assert.NotEqual(newCategory.Description, currentCategory.Description);            
        }
    }
}
