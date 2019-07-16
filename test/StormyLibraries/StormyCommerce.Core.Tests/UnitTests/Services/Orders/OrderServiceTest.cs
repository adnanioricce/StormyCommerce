namespace StormyCommerce.Core.Tests.UnitTests.Services.Orders
{
    public class OrderServiceTest
    {
        private readonly Guid uniqueOrderKey = Guid.NewGuid();
        [Fact]
        public void GetOrderByIdAsync_ExistingOrderWithIdEqualOne_ShouldReturnOkResultIfSuccess()
        {            
            //Arrange
            using (var dbContext = DbContextHelper.GetDbContext(DbContextHelper.GetDbOptions()))
            {                         
                dbContext.Add(SampleOrderDataHelper.GetOrderData(uniqueOrderKey));
                dbContext.SaveChanges();
            }            
            var service = new OrderService(new StormyRepository<StormyOrder>(dbContext));
            //When
            var order = await service.GetOrderbyId(1);                
            //Then
            Assert.Equal(1,Order.Id);                                
        }        
    }
}
