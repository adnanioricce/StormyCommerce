﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Services.Catalog;
using StormyCommerce.Infraestructure.Data.Repositories;
using StormyCommerce.Module.Catalog.Controllers;
using StormyCommerce.WebHost.Mappings;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

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
            var dbContext = DbContextHelper.GetDbContext();
            dbContext.AddRange(_data);
            dbContext.SaveChanges();            
            var repository = new StormyRepository<Category>(dbContext);            
            var categoryService = new CategoryService(repository, CreateEntityService());            
            var profile = new CatalogProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));            
            var mapper = configuration.CreateMapper();            
            return new CategoryController(categoryService, mapper,null);
        }

        private EntityService CreateEntityService()
        {
            return new EntityService(TestHelperLibrary.Utils.RepositoryHelper.GetRepository<Entity>());
        }

        [Fact]
        public async Task GetAll_NoArgumentsAndWith50EntitiesOnDatabase_ReturnListWithAll15EntitiesInTheDtoVersion()
        {
            // Act
            var result = await _categoryController.GetAll();
            // Assert
            //TODO: Change to check against a defined length
            Assert.Equal(15, result.Value.Count);
        }

        [Fact]
        public async Task GetCategoryById_IdEqualOneExistingEntity_ReturnEntityWithIdEqualOne()
        {
            // Arrange
            long id = 1;

            // Act
            var result = await _categoryController.GetCategoryById(id);

            // Assert
            Assert.Equal(id, result.Value.Id);
        }

        [Fact]
        public async Task CreateCategory_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var category = new Category(Seeders.CategorySeed(1).Last(), 16);
            // Act
            var result = await _categoryController.CreateCategory(category);
            // Assert
            var returnResult = Assert.IsAssignableFrom<OkObjectResult>(result);
            Assert.Equal(200, returnResult.StatusCode);
        }

        [Fact]
        public async Task EditCategory_UpdatingExistingEntityWithNewChildrensAndName_ReturnAOkObjectResultIfSuccessful()
        {
            var repository = RepositoryHelper.GetRepository<Category>();
            // Arrange
            var category = _data.Find(c => c.Id == 1);              
            category.Name += " Updated";
            // Act
            var result = await _categoryController.EditCategory(category);
            // Assert
            var returnResult = Assert.IsAssignableFrom<OkObjectResult>(result);
            Assert.Equal(200, returnResult.StatusCode);
            Assert.Equal(1, category.Id);
        }
    }
}
