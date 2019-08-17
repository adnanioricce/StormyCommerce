namespace StormyCommerce.Module.Orders.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class OrderController
	{
		private readonly IOrderService _orderService;
		//TODO:Add the payment Service 
		public OrderController(IOrderService orderService)
		{
			_orderService = orderService;
		}
		[HttpPost("/create")]
		[ValidateModel]
		public async Task CreateOrder([FromBody] OrderDto orderDto)
		{

			_orderService.CreateOrderAsync(orderDto);
			
		}
	}
}
