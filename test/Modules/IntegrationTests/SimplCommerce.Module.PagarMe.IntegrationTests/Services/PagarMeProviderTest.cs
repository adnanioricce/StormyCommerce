using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using PagarMe;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Core.Data;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.Payments.Interfaces;
using SimplCommerce.Module.Payments.Models;
using Xunit;

namespace SimplCommerce.Module.PagarMe.IntegrationTests.Services
{
    public class PagarMeProviderTest
    {
        private readonly IPaymentProvider _service;
        private readonly UserManager<User> _userManager;
        private readonly IRepository<Payment> _paymentRepository;
        private readonly IRepository<Order> _orderRepository;
       public PagarMeProviderTest(IPaymentProvider service,
           UserManager<User> userManager,
           SimplDbContext context,
           IRepository<Payment> paymentRepository,
           IRepository<Order> orderRepository,
           IConfiguration configuration)
       {
            _service = service;   
            _userManager = userManager;
            _paymentRepository = paymentRepository;
            _orderRepository = orderRepository;
            SetTestData(context);
       } 
       [Fact]
       public void ProcessTransaction_ReceivesAmountAndItemsAndUserBillingInfo_ShouldReturnProcessTransactionResponseWithSucessEqualTrue()
       {
            //Given
            var request = GetProcessTransactionRequestDataForBoleto();
            var order = _orderRepository.Query().FirstOrDefault(p => p.Id == 1);
            request.Items = order.OrderItems.ToList();
            request.TotalAmount = order.OrderTotal;
            request.User = order.Customer;
            //When
            var response = _service.ProcessTransaction(request);
            //Then
            var payment = _paymentRepository.Query().FirstOrDefault(p => p.Id == response.PaymentId);
            Assert.True(response.Success);
            Assert.Equal(262.40m, payment.Amount);            
       }
        [Fact]
        public void ProcessTransaction_ReceivesAmountAndItemsAndUserBillingInfoWithCreditCardAsPaymentMethod_ShouldReturnProcessTransactionResponseWithSucessEqualTrue()
        {
            //Given
            var request = GetProcessTransactionRequestDataForBoleto();
            var order = _orderRepository.Query().FirstOrDefault(p => p.Id == 1);
            request.Items = order.OrderItems.ToList();
            request.TotalAmount = order.OrderTotal;
            request.User = order.Customer;
            //When
            var response = _service.ProcessTransaction(request);
            //Then
            var payment = _paymentRepository.Query().FirstOrDefault(p => p.Id == response.PaymentId);
            Assert.True(response.Success);
            Assert.Equal(262.40m, payment.Amount);
        }
        private void SetTestData(SimplDbContext dbContext)
        {
            var user = GetUserWithoutDefaultAddresses();
            var product = GetProduct();
            SetAddressData(dbContext);
            SetUserData(dbContext,user);
            product.CreatedBy = user;
            product.LatestUpdatedBy = user;
            SetProductData(dbContext,product);
            var order = GetOrder(1);
            order.CreatedBy = user;
            order.LatestUpdatedBy = user;
            order.Customer = user;
            dbContext.Add(order);
            dbContext.SaveChanges();            
        }
        private Product GetProduct()
        {
            return new Product
            {
                Name = "test name",
                Slug = "test-name",
                Price = 120.0m,
                StockQuantity = 2                
            };
        }
        private void SetProductData(SimplDbContext context,Product product)
        {
            
            context.Add(product);
            context.SaveChanges();
        }
       private void SetUserData(SimplDbContext context,User user)
       {
            context.Add(user);
            context.SaveChanges();
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
       }
       private Order GetOrder(long userId){
            var order = new Order
            {                
                SubTotal = 240,
                ShippingAddressId = 1,
                BillingAddressId = 1,
                OrderStatus = OrderStatus.OnHold,
                ShippingFeeAmount = 22.4m,
                PaymentMethod = "boleto",
                PaymentFeeAmount = 12.99m,
                OrderTotal = 262.40m
            };
            order.AddOrderItem(new OrderItem
            {
                ProductPrice = 120.0m,
                ProductId = 1,
                Quantity = 2
            });
            return order;
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
               Culture = "BR",
               PhoneNumber = "+551123456789",
               Roles = new List<UserRole>{
                   new UserRole{
                       RoleId = 1
                   }
               },
               ExtensionData = @"{
                    'Documents' : [
                        {
                            'Type':'cpf',
                            'Value':'76942610054'
                        }   
                    ]}
                "
           };
       }
       private ProcessTransactionRequest GetProcessTransactionRequestDataForBoleto()
       {                      
           return new ProcessTransactionRequest{
               OrderId = 1,               
               UserId = 1,
               PaymentMethod = "boleto"               
           };
       }
        private ProcessTransactionRequest GetTransactionRequestDataForCreditCard()
        {
            return new ProcessTransactionRequest
            {

            };
        }
    }   
}
