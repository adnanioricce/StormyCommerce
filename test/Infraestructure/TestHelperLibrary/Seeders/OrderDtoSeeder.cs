using StormyCommerce.Core.Tests.Helpers;
namespace TestHelperLibrary.Seeders
{
	public static class OrderDtoSeeder
	{
		public static OrderDto CreateOrderData()
		{
			return new OrderDto(OrderDataSeeder.GetOrderData());
		}
	}
}
