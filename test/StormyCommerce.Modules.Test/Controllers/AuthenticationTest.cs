using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using SimplCommerce.WebHost;
using StormyCommerce.Infraestructure.Entities;
using StormyCommerce.Infraestructure.Interfaces;
using StormyCommerce.Module.Customer.Services;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TestHelperLibrary;
using TestHelperLibrary.Utils;
using Xunit;

namespace StormyCommerce.Modules.IntegrationTest.Controllers
{
    public class UserIdentityControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly HttpClient _client;
        public UserIdentityControllerTest(WebApplicationFactory<Startup> factory)
        {
           _factory = factory;              
           _client = factory.CreateClient();                     
        }
        [Fact]
        public async Task Post_RegisterAsync_ValidInputData_Return200()
        {
           //Arrange 
           var data = new Dictionary<string,string>{               
               {"Username" , "sampleuser"},
               {"Email", "example@email.com"},
               {"Password","!SenhaSuperSegura666"}
           };
           //Act 
           //?This probably will throw a error, I think he expects for a JSON.
           var response = await _client.PostAsJsonAsync("/api/authentication/RegisterAsync",data);
           response.EnsureSuccessStatusCode();
           //Assert
           Assert.Equal(200,(int)response.StatusCode);
           Assert.Equal("application/json;charset=utf-8",response.Content.Headers.ContentType.ToString());
        }        
        [Fact]
        public async Task Post_LoginAsync_ValidInputData_Return200OkStatusCodeAndCorrectFormatting()
        {
            //Arrange
            var data = new Dictionary<string,string>{
                {"Username","sampleuser"},
                {"Password","!AAwesomeP4sswd"},
                {"Email","example@email.com"}
            };
            //Act
            var response = await _client.PostAsJsonAsync("/api/authentication/RegisterAsync",data);
            response.EnsureSuccessStatusCode();
            //Assert
            Assert.Equal(200,(int)response.StatusCode);
            Assert.Equal("application/json;charset=utf-8",response.Content.Headers.ContentType.ToString());
        }
        //How you pass a object instead of a primitive?
        // [Theory]        
        // [InLineData("sampleuser","asdf","example&email.com")]
        // public async Task Post_RegisterAsync_InvalidInputData_ReturnCorrespondentErrorStatusCode(string username,string password,string email)
        // {
        //     //Arrange 
        //     var data = new Dictionary<string,string>{
        //         {"Username",username},
        //         {"Password",password},
        //         {"Email",email}
        //     };
        //     //
        //     var response = await _client.PostAsJsonAsync("/api/authentication/RegisterAsync"); 
        //     //How Should I get the others errors?
        //     Assert.NotEqual(200,(int)response.StatusCode);
        // }
    }
}
