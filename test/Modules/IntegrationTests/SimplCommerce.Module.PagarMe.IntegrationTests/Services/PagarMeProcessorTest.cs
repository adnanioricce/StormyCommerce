using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Data;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.Payments.Interfaces;
using SimplCommerce.Module.Payments.Models;
using Xunit;

namespace SimplCommerce.Module.PagarMe.IntegrationTests.Services
{
    public class PagarMeProcessorTest
    {
        private readonly IPaymentProvider _service;
        private readonly UserManager<User> _userManager;
        private readonly IRepository<Payment> _paymentRepository;
       public PagarMeProcessorTest(IPaymentProvider service,UserManager<User> userManager,SimplDbContext context,IRepository<Payment> paymentRepository)
       {
            _service = service;   
            _userManager = userManager;
            _paymentRepository = paymentRepository;
            SetTestData(context);
       } 
       [Fact]
       public void ProcessTransaction_ReceivesAmountAndItemsAndUserBillingInfo_ShouldReturnProcessTransactionResponseWithSucessEqualTrue()
       {
            //Given
            var request = GetProcessTransactionRequestData();
            //When
            var response = _service.ProcessTransaction(request);
            //Then
            var payment = _paymentRepository.Query().FirstOrDefault(p => p.Id == response.PaymentId);
            Assert.True(response.Success);
            Assert.Equal(275.35m,payment.Amount);            
       }
       private void SetTestData(SimplDbContext dbContext)
       {
            SetAddressData(dbContext);
            SetUserData(dbContext);         
                   
       }
       private void SetUserData(SimplDbContext context)
       {
           context.Add(GetUserWithoutDefaultAddresses());           
       }
       private void SetAddressData(SimplDbContext context)
       {
            var country = GetCountry();
            var state = GetDefaultState();
            country.StatesOrProvinces.Add(state);
            context.Add(country);
            context.SaveChanges();
            context.Add(GetDefaultDistrict());
            context.SaveChanges();
            context.Add(GetOrderAddress());
            context.SaveChanges();
            context.Add(GetOrder(1));
            context.SaveChanges();
       }
       private Order GetOrder(long userId){
           return new Order{
                CustomerId = userId,
                LatestUpdatedById = userId,
                CreatedById = userId,
                SubTotal = 240,
                ShippingAddressId = 1,
                BillingAddressId = 1,
                OrderItems = new List<OrderItem>{
                    new OrderItem{
                        ProductPrice = 120.0m,
                        ProductId = 1,
                        Quantity = 2                        
                    }
                },
                OrderStatus = OrderStatus.OnHold,
                ShippingFeeAmount = 22.4m,
                PaymentMethod = "boleto",
                PaymentFeeAmount = 12.99m,
           };
       }       
       private District GetDefaultDistrict(){
           return new District{
               StateOrProvinceId = 1,
               Name = "default district"             
           };
       }
       private StateOrProvince GetDefaultState()
       {
           return new StateOrProvince{               
               CountryId = "Test",
               Name = "test state"
           };
       }
       private Country GetCountry(){
           return new Country("Test"){
               Name = "Test Country"

           };
       }
       private OrderAddress GetOrderAddress(){
           return new OrderAddress{               
               ContactName = "test name",
               Phone = "+5511996022222",
               AddressLine1 = "R.Test",
               AddressLine2 = "D.Test",
               City = "Test City",
               ZipCode = "12345678",
               DistrictId = 1,
               StateOrProvinceId = 1,
               CountryId = "Test"
           };
       }
       private User GetUserWithoutDefaultAddresses()
       {
           return new User {
               Id = 1,
               UserGuid = Guid.NewGuid(),
               FullName = "test user fullname",
               Email = "test@email.com",
               Roles = new List<UserRole>{
                   new UserRole{
                       RoleId = 1
                   }
               }               
           };
       }
       private ProcessTransactionRequest GetProcessTransactionRequestData()
       {                      
           return new ProcessTransactionRequest{
               OrderId = 1,               
           };
       }
    }   
}
