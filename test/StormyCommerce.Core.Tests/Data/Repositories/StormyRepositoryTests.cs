using StormyCommerce.Core.Entities;
using StormyCommerce.Core.Interfaces;
using StormyCommerce.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Core.Tests.Data.Repositories
{
    public class StormyRepositoryTests<TEntity> : IDisposable where TEntity : BaseEntity
    {
        private IStormyRepository<TEntity> _repository;

        //private Mock<StormyDbContext> mockStormyDbContext;

        public StormyRepositoryTests()
        {
            _repository = CreateStormyRepository<TEntity>();
        }

        private IStormyRepository<T> CreateStormyRepository<T>() where T : BaseEntity
        {
            return RepositoryHelper.GetRepository<T>();
        }

        [Fact]
        public async Task AddAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var stormyRepository = this.CreateStormyRepository<BaseEntity>();
            TEntity _entity = null;

            // Act
            await stormyRepository.AddAsync(_entity);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task AddCollectionAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var stormyRepository = this.CreateStormyRepository<BaseEntity>();
            IEnumerable<BaseEntity> _entities = null;

            // Act
            await stormyRepository.AddCollectionAsync(_entities);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Delete_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var stormyRepository = this.CreateStormyRepository<BaseEntity>();
            TEntity _entity = null;

            // Act
            stormyRepository.Delete(_entity);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void DeleteCollection_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var stormyRepository = this.CreateStormyRepository<BaseEntity>();
            IEnumerable<BaseEntity> _entities = null;

            // Act
            stormyRepository.DeleteCollection(_entities);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var stormyRepository = this.CreateStormyRepository<BaseEntity>();

            // Act
            var result = await stormyRepository.GetAllAsync();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetByIdAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var stormyRepository = this.CreateStormyRepository<BaseEntity>();
            long id = 0;

            // Act
            var result = await stormyRepository.GetByIdAsync(id);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var stormyRepository = this.CreateStormyRepository<BaseEntity>();
            TEntity _entity = null;

            // Act
            await stormyRepository.UpdateAsync(_entity);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateCollectionAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var stormyRepository = this.CreateStormyRepository<BaseEntity>();
            IEnumerable<BaseEntity> _entities = null;

            // Act
            await stormyRepository.UpdateCollectionAsync(_entities);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllByIdsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var stormyRepository = this.CreateStormyRepository<BaseEntity>();
            long[] ids = null;

            // Act
            var result = await stormyRepository.GetAllByIdsAsync(ids);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void BeginTransaction_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var stormyRepository = this.CreateStormyRepository<BaseEntity>();

            // Act
            var result = stormyRepository.BeginTransaction();

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void IsItNew_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var stormyRepository = this.CreateStormyRepository<BaseEntity>();
            StormyDbContext context = null;
            TEntity entity = null;

            // Act
            //var result = stormyRepository.IsItNew(
            //    context,
            //    entity);

            // Assert
            Assert.True(false);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
