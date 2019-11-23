using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using SimplCommerce.WebHost;
using StormyCommerce.Api.Framework.Extensions;
using StormyCommerce.Core.Entities.Catalog.Product;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Catalog;
using Xunit;
using Xunit.Extensions;

namespace StormyCommerce.Modules.Test.Endpoints
{
    public class ProductControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly HttpClient _client;        
        public ProductControllerTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();
        }
        //TODO:What Errors codes should I return?
        #region Admin Area
        #region Post
        [Theory]
        [InlineData("/api/product/create")]        
        public async Task Post_CreateProduct_ValidInput_ShouldReturn200StatusCode(string url)
        {
            //Arrange 
            var product = Seeders.StormyProductSeed().First();
            product.Id = 0;
            //Act
            var response = await _client.PostAsJsonAsync(url,product);
            //Assert
            Assert.Equal(200,(int)response.StatusCode);            
        }
        [Fact]        
        public async Task Post_Create_InvalidInput_ShouldCorrespondentReturnErrorCode()
        {                                    
            //Act
            var response = await _client.PostAsJsonAsync("/api/product/create", StormyProductData());
            //Assert
            Assert.Equal(400,(int)response.StatusCode);            
        }
        #endregion
        #region Put
        [Fact]       
        public async Task Put_Edit_ValidInput_ShouldReturn200StatusCode()
        {
            //Arrange 
            var productData = StormyProductData();
            productData.Id = 1;
            //Act
            var response = await _client.PutAsJsonAsync("/api/product/edit",productData);
            //Assert
            Assert.Equal(200,(int)response.StatusCode);            
        } 
        [Fact]        
        public async Task Put_Edit_InvalidInput_ShouldReturn400BadRequest()
        {
            //Arrange 
            var productData = StormyProductInvalidData();
            productData.Id = 1;
            //Act
            var response = await _client.PutAsJsonAsync("/api/product/edit", productData);
            //Assert
            Assert.Equal(200,(int)response.StatusCode);            
        }   
        #endregion
        #endregion    
        #region Common User Area 
        [Theory]
        [InlineData("api/Product/get?id=",1)]
        public async Task Get_ById_ShouldReturnProductDtoWithGivenId(string url,long id)
        {                        
            //When
            var response = await _client.GetAsync(url + id);   
            var data = await response.Content.ReadAsAsync<ProductDto>();
            //Then
            Assert.Equal(200,(int)response.StatusCode);
            Assert.Equal(id,data.Id);
        }
        [Theory]
        [InlineData("api/Product/list",1,15)]
        public async Task Get_List_ShouldReturnCollectionOfProductDto(string url,int startIndex,int endIndex)
        {                                 
            //When
            var response = await _client.GetAsync(url + $"?startIndex={startIndex}&endIndex={endIndex}");   
            var data = await response.Content.ReadAsAsync<List<ProductDto>>();
            //Then
            Assert.Equal(200,(int)response.StatusCode);
            Assert.Equal(endIndex,data.Count);
        }
        #endregion
        public static StormyProduct StormyProductData(){
            return Seeders.StormyProductSeed().First();
        }
        public static IEnumerable<StormyProduct> StormyProductCollectionData(){
            return Seeders.StormyProductSeed(3);
        }
        public static StormyProduct StormyProductInvalidData(){
            var product = Seeders.StormyProductSeed(1).First();            
            product.ThumbnailImage = null;
            product.CategoryId = 0; 
            product.Categories = null; 
            product.Brand = null;
            product.BrandId = 0;
            product.Vendor = null;
            product.VendorId = 0;
            return product;
        }
    }
}
