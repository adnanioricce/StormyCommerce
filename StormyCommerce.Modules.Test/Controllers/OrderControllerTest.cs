using SimplCommerce.WebHost;
using StormyCommerce.Core.Interfaces.Domain.Order;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Orders;
using StormyCommerce.Modules.IntegrationTest;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
namespace StormyCommerce.Module.Test.Controllers
{
	//TODO:Maybe a more DRY way of use the HttpClient Instance?
	public class OrderControllerTest : IClassFixture<TestFixture<Startup>>
	{
		//What is the base address? 
		private readonly IOrderService _orderService;
		private readonly HttpClient _httpClient;
		public OrderControllerTest(TestFixture<Startup> factory)
		{
            _orderService = (IOrderService)factory.Server.Host.Services.GetService(typeof(IOrderService));
			_httpClient = factory.CreateClient();
		}
		[Fact]
		public async Task CreateOrder_ValidOrderDto_ShouldCreateNewOrder()
		{
			//Arrange             
			var order = new OrderDto(null);
            //Act
            //Assert
			Assert.Equal("application/json; charset=utf-8;","");
		}
	}
}
