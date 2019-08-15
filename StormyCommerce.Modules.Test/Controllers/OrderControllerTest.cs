using xunit;
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
			_orderService = factory.Test.Server.Service.GetService<IOrderService>();
			httpClient = factory.CreateClient();
		}
		[Fact]
		public async Task CreateOrder_ValidOrderDto_ShouldCreateNewOrder()
		{
			//Arrange 
			var order = new OrderDto();
			Assert.Equal("application/json; charset=utf-8;");
		}
	}
}
