using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
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
using Xunit.Abstractions;

namespace StormyCommerce.Modules.IntegrationTest.Controllers
{
    public class UserIdentityControllerTest : IClassFixture<CustomWebApplicationFactory>
    {        
        private readonly HttpClient _client;
        private readonly ITestOutputHelper _output;
        public UserIdentityControllerTest(CustomWebApplicationFactory factory,ITestOutputHelper output)
        {                
           _client = factory.WithWebHostBuilder(builder =>
           {
               builder.UseSolutionRelativeContentRoot("src/SimplCommerce.WebHost");               
           }).CreateClient();
           _output = output;
        }
        [Fact]
        public async Task Post_RegisterAsync_ValidInputData_Return200()
        {
           //Arrange 
           var data = new Dictionary<string,string>{               
               {"Username" , "sampleuser"},
               {"Email", "example@email.com"},
               {"Password","!SenhaSuperSegura6663"},
               {"ConfirmPassword","!SenhaSuperSegura6663"},               
           };
           //Act 
           //?This probably will throw a error, I think he expects for a JSON.
           var response = await _client.PostAsJsonAsync("api/authentication/register", data);
           var output = await response.Content.ReadAsStringAsync();
            _output.WriteLine($"response content:{output}");
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
               {"username" , "sampleuser"},
               {"email", "example@email.com"},
               {"password","!SenhaSuperSegura666"},
               {"confirmPassword","!SenhaSuperSegura666"},
            };
            //Act
            await _client.PostAsJsonAsync("api/authentication/register",data);
            data.Remove("ConfirmPassword");
            var response = await _client.PostAsJsonAsync("api/authentication/login", data);
            var output = await response.Content.ReadAsStringAsync();
            _output.WriteLine($"response content:{output}");
            response.EnsureSuccessStatusCode();
            //Assert
            Assert.Equal(200,(int)response.StatusCode);
            Assert.Equal("application/json;charset=utf-8",response.Content.Headers.ContentType.ToString());
        }
        //How you pass a object instead of a primitive?
        [Theory]
        [InlineData("sampleuser", "asdf", "example&email.com")]
        [InlineData("","","")]
        [InlineData("","","example@email.com")]
        public async Task Post_RegisterAsync_InvalidInputData_ReturnCorrespondentErrorStatusCode(string username, string password, string email)
        {
            //Arrange 
            var data = new Dictionary<string, string>{
                 {"Username",username},
                 {"Password",password},
                 {"Email",email}
             };
            //
            var response = await _client.PostAsJsonAsync("/api/authentication/RegisterAsync",data);
            //How Should I get the others errors?
            Assert.NotEqual(200, (int)response.StatusCode);
        }
    }
}
