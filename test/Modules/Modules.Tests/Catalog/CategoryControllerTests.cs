using StormyCommerce.Core.Interfaces;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Module.Catalog.Area.Controllers;
using TestHelperLibrary.Mocks;
using System;
using System.Threading.Tasks;
using System.Linq;
using Xunit;
using SimplCommerce.Module.SampleData.Extensions;
using StormyCommerce.Module.Catalog.Extensions;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Core.Entities.Catalog;
using AutoMapper;
using StormyCommerce.Core.Services.Catalog;
using TestHelperLibrary.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StormyCommerce.Core.Entities;

namespace Modules.Test
{
    public class CategoryControllerTests
    {        
        private readonly CategoryController _categoryController;
        private readonly List<Category> _data = Seeders.CategorySeed(15);
        public CategoryControllerTests()
        {
            _categoryController = CreateController();
        }
        private CategoryController CreateController()
        {
            //Creating fake data
            var dbContext = DbContextHelper.GetDbContext();                        
            dbContext.AddRange(_data);            
            dbContext.SaveChanges();
            //Creating Repository
            var repository = new StormyRepository<Category>(dbContext);
            //Creating the CategoryService
            var categoryService = new CategoryService(repository,CreateEntityService());
            //Creating the profile for AutoMapper
            var profile = new CatalogProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            //Creating a AutoMapper instance
            var mapper = configuration.CreateMapper();
            //Finnaly, creating the controller
            return new CategoryController(categoryService, mapper);
        }
        private EntityService CreateEntityService()
        {
            return new EntityService(RepositoryHelper.GetRepository<Entity>());
        }
        [Fact]
        public async Task GetAll_NoArgumentsAndWith15EntitiesOnDatabase_ReturnListWithAll15EntitiesInTheDtoVersion()
        {            
            // Act
            var result = await _categoryController.GetAll();
            // Assert
            //TODO: Change to check against a defined length
            Assert.Equal(15,result.Value.Count);
        }

        [Fact]
        public async Task GetCategoryById_IdEqualOneExistingEntity_ReturnEntityWithIdEqualOne()
        {
            // Arrange            
            long id = 1;

            // Act
            var result = await _categoryController.GetCategoryById(id);

            // Assert
            Assert.Equal(id,result.Value.Id);
        }

        [Fact]
        public async Task CreateCategory_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            var category = Seeders.CategorySeed(16).Last();            
            // Act
            var result = await _categoryController.CreateCategory(category);            
            // Assert
            var returnResult = Assert.IsAssignableFrom<OkObjectResult>(result);
            Assert.Equal(200,returnResult.StatusCode);            
        }

        [Fact]
        public async Task EditCategory_UpdatingExistingEntityWithNewChildrensAndName_ReturnAOkObjectResultIfSuccessful()
        {
            // Arrange            
            var category = _data.FirstOrDefault(f => f.Id == 1);            
            category.Parent = _data.FirstOrDefault(f => f.Id == 2);
            category.AddChildren(Seeders.CategorySeed(4).GetRange(2,2));
            category.Name += " Updated";            
            // Act
            var result = await _categoryController.EditCategory(category);
            // Assert     
            var returnResult = Assert.IsAssignableFrom<OkObjectResult>(result);            
                   
            
        }
    }
}
