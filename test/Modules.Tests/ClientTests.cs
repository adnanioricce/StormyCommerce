using Moq;
using Stormycommerce.Module.Orders.Area.ViewModels;
//using StormyCommerce.Api.Client;
using StormyCommerce.Core.Entities.Catalog;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Module.Customer.Areas.Customer.ViewModels;
using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
//This don't seem a good idea now
namespace Modules.Tests
{
    //public class ClientTests : IDisposable
    //{
    //    private MockRepository mockRepository;



    //    public ClientTests()
    //    {
    //        this.mockRepository = new MockRepository(MockBehavior.Strict);


    //    }

    //    public void Dispose()
    //    {
    //        this.mockRepository.VerifyAll();
    //    }

    //    private Client CreateClient()
    //    {
    //        return new Client(
    //            TODO);
    //    }

    //    [Fact]
    //    public async Task LoginAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        SignInVm signInVm = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.LoginAsync(
    //            signInVm,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task RegisterAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        SignUpVm signUpVm = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.RegisterAsync(
    //            signUpVm,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task ConfirmEmailAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        string email = null;
    //        string code = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.ConfirmEmailAsync(
    //            email,
    //            code,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task ResetPasswordAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        ResetPasswordViewModel model = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.ResetPasswordAsync(
    //            model,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task ForgotPasswordAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        ForgotPasswordViewModel model = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.ForgotPasswordAsync(
    //            model,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task GetAllAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.GetAllAsync(
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task GetCategoryByIdAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        long id = 0;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.GetCategoryByIdAsync(
    //            id,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task CreateCategoryAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        Category category = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.CreateCategoryAsync(
    //            category,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task EditCategoryAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        string id = null;
    //        Category category = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.EditCategoryAsync(
    //            id,
    //            category,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task CheckoutBoletoAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        CheckoutOrderVm checkoutVm = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.CheckoutBoletoAsync(
    //            checkoutVm,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task AddAddressAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        Address address = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.AddAddressAsync(
    //            address,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task WriteReviewAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        CustomerReviewDto review = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.WriteReviewAsync(
    //            review,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task GetCustomersAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        int? minLimit = null;
    //        long? maxLimit = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.GetCustomersAsync(
    //            minLimit,
    //            maxLimit,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task GetCustomerByEmailOrUsernameAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        string email = null;
    //        string username = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.GetCustomerByEmailOrUsernameAsync(
    //            email,
    //            username,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task CreateCustomerAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        CustomerDto customerDto = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.CreateCustomerAsync(
    //            customerDto,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task CreateOrderAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        OrderDto orderDto = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.CreateOrderAsync(
    //            orderDto,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task GetProductOverviewAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        string _0 = null;
    //        long? id = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.GetProductOverviewAsync(
    //            _0,
    //            id,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task GetAllProductsAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        long? startIndex = null;
    //        long? endIndex = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.GetAllProductsAsync(
    //            startIndex,
    //            endIndex,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task GetAllProductsOnHomepageAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        int? limit = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.GetAllProductsOnHomepageAsync(
    //            limit,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task GetProductByIdAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        string _0 = null;
    //        long? id = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.GetProductByIdAsync(
    //            _0,
    //            id,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task CreateProductAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        ProductDto _model = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.CreateProductAsync(
    //            _model,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task EditProductAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        ProductDto _model = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.EditProductAsync(
    //            _model,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task GetNumberOfProductsInCategoryAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        IEnumerable categoryIds = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.GetNumberOfProductsInCategoryAsync(
    //            categoryIds,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task GetAllProductsOnCategoryAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        int? categoryId = null;
    //        int? limit = null;
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.GetAllProductsOnCategoryAsync(
    //            categoryId,
    //            limit,
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }

    //    [Fact]
    //    public async Task SeedDatabaseAsync_StateUnderTest_ExpectedBehavior()
    //    {
    //        // Arrange
    //        var client = this.CreateClient();
    //        CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

    //        // Act
    //        var result = await client.SeedDatabaseAsync(
    //            cancellationToken);

    //        // Assert
    //        Assert.True(false);
    //    }
    //}
}
