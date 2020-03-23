using MediatR;
using Moq;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Core.Data;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Module.Core.Services;
using SimplCommerce.Module.Orders.Areas.Orders.ViewModels;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.Orders.Services;
using SimplCommerce.Module.Pricing.Services;
using SimplCommerce.Module.ShippingPrices.Services;
using SimplCommerce.Module.ShoppingCart.Models;
using SimplCommerce.Module.ShoppingCart.Services;
using SimplCommerce.Module.Tax.Services;
using SimplCommerce.Tests;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
//TODO: this will take a lot of time
namespace SimplCommerce.Module.Orders.UnitTests.Services
{
    public class OrderServiceTests
    {
        private MockRepository mockRepository;              
        [Fact]
        public async Task CreateOrder_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var fakeProductRepository = new FakeRepository<Product>();
            //var fakeUserRepository = new FakeRepositoryWithTypedId<User,string>();
            var fakeCartRepository = new FakeRepository<Cart>();            
            var fakeAddressRepository = new FakeRepository<Address>();
            var fakeOrderRepository = new FakeRepository<Order>();
            var cart = GetCart();            
            cart.Items = GetCartItems();
            var address = GetShippingAddress();
            fakeAddressRepository.Add(address);
            fakeCartRepository.Add(cart);            
            //fakeUserRepository.Add(GetUser());            
            fakeProductRepository.Add(GetProduct());            
            var service = new OrderService(fakeOrderRepository,fakeCartRepository,GetFakeCouponService(),null, null, GetFakeTaxService(),null,GetFakeShippingPriceService(),null, GetFakeMediator());
            long cartId = 0;
            string paymentMethod = null;
            decimal paymentFeeAmount = 0;
            OrderStatus orderStatus = default(global::SimplCommerce.Module.Orders.Models.OrderStatus);

            // Act
            var result = await service.CreateOrder(
                cartId,
                paymentMethod,
                paymentFeeAmount,
                orderStatus);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task CreateOrder_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange

            var service = new OrderService(null, null, null, null, null, null, null, null, null, null);
            long cartId = 0;
            string paymentMethod = null;
            decimal paymentFeeAmount = 0;
            string shippingMethodName = null;
            Address billingAddress = null;
            Address shippingAddress = null;
            OrderStatus orderStatus = default(global::SimplCommerce.Module.Orders.Models.OrderStatus);

            // Act
            var result = await service.CreateOrder(
                cartId,
                paymentMethod,
                paymentFeeAmount,
                shippingMethodName,
                billingAddress,
                shippingAddress,
                orderStatus);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void CancelOrder_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new OrderService(null, null, null, null, null, null, null, null, null, null);
            Order order = null;

            // Act
            service.CancelOrder(
                order);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task GetTax_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new OrderService(null, null, null, null, null, null, null, null, null, null);
            long cartId = 0;
            string countryId = null;
            long stateOrProvinceId = 0;
            string zipCode = null;

            // Act
            var result = await service.GetTax(
                cartId,
                countryId,
                stateOrProvinceId,
                zipCode);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public async Task UpdateTaxAndShippingPrices_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var service = new OrderService(null, null, null, null, null, null, null, null, null, null);
            long cartId = 0;
            TaxAndShippingPriceRequestVm model = null;

            // Act
            var result = await service.UpdateTaxAndShippingPrices(cartId,model);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }        
        private IShippingPriceService GetFakeShippingPriceService()
        {
            var mockShippingPrice = new Mock<IShippingPriceService>();
            mockShippingPrice.Setup(m => m.GetApplicableShippingPrices(It.IsAny<GetShippingPriceRequest>()))
                .ReturnsAsync(new List<ShippingPrice> {
                    new ShippingPrice(new FakeCurrencyService())
                   {
                       Name = "test price",
                       Description = "test description",
                       Price = 12.99m
                   }
                });
            return mockShippingPrice.Object;
        }
        private ITaxService GetFakeTaxService()
        {
            var mockTaxService = new Mock<ITaxService>();
            mockTaxService.Setup(d => d.GetTaxPercent(It.IsAny<long?>(), It.IsAny<string>(), It.IsAny<long>(), It.IsAny<string>()))
                .ReturnsAsync(1);
            return mockTaxService.Object;
        }
        private ICouponService GetFakeCouponService()
        {
            var fakeCouponService = new Mock<ICouponService>();
            fakeCouponService.Setup(m => m.AddCouponUsage(It.IsAny<long>(), It.IsAny<long>(), It.IsAny<CouponValidationResult>()))
                .Callback(() => Console.Write(""));
            return fakeCouponService.Object;
        }
        private IMediator GetFakeMediator()
        {
            var mockMediator = new Mock<IMediator>();
            mockMediator.Setup(m => m.Publish(It.IsAny<object>(), It.IsAny<CancellationToken>()))
                .Callback(() => Console.WriteLine("nothing"));
            return mockMediator.Object;
        }
        //private void SetData(SimplDbContext dbContext)
        //{
        //    var user = GetUser();
        //    var product = GetProduct();
        //    SetAddressData(dbContext);
        //    dbContext.Add(user);
        //    dbContext.SaveChanges();
        //    product.CreatedBy = user;
        //    product.LatestUpdatedBy = user;
        //    dbContext.Add(product);
        //    dbContext.SaveChanges();
        //    var order = GetOrder(1);
        //    order.CreatedBy = user;
        //    order.LatestUpdatedBy = user;
        //    order.Customer = user;
        //    dbContext.Add(order);
        //    dbContext.SaveChanges();
        //}

        private void SetAddressData(SimplDbContext dbContext)
        {
            dbContext.Add(GetCountry());
            dbContext.SaveChanges();
            dbContext.Add(GetStateOrProvince());
            dbContext.SaveChanges();
            dbContext.Add(GetDistrict());
            dbContext.SaveChanges();
        }    
        //private (User,Product,Cart) GetCartDataForFirstChargeMethodWithAddressIds()
        //{
        //    var cart = GetCart();
        //    cart.Items = GetCartItems();
        //    cart.ShippingData = GetJsonShippingDataWithIds();            
        //}
        private Country GetCountry()
        {
            return new Country("BR")
            {
                IsShippingEnabled = true,
                Name = "Brasil"
            };
        }
        private StateOrProvince GetStateOrProvince()
        {
            return new StateOrProvince
            {
                Name = "Test province",
                CountryId = "Brazil"
            };
        }
        private District GetDistrict()
        {
            return new District
            {
                Name = "Test district",
                StateOrProvinceId = 1
            };
        }
        private Cart GetCart()
        {
            return new Cart
            {
                Items = GetCartItems(),
                IsActive = true,
                CustomerId = 1,
                CreatedById = 1,
                ShippingMethod = "40010"                
            };            
        }
        private List<CartItem> GetCartItems()
        {
            return new List<CartItem>
                {
                    new CartItem
                    {
                        ProductId = 1,
                        Quantity = 2
                    }
                };
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
        private Address GetShippingAddress()
        {
            return new Address
            {
                AddressLine1 = "address line 1",
                AddressLine2 = "address line 2",
                ContactName = "contact name",
                CountryId = "BR",
                StateOrProvinceId = 1,
                DistrictId = 1,
                City = "Some city",
                ZipCode = "11443-360",
                Phone = "+55(81)543-956124"
            };
        }        
        private string GetJsonShippingDataWithIds()
        {
            return @"{
                'ShippingAddressId':1,
                'BillingAddressId':1,
                'UseShippingAddressAsBillingAddress':true
            }";
        }
        private string GetJsonShippingData()
        {
            return @"{
                    'NewAddressForm':{
                        'AddressLine1':'address line 1',
                        'AddressLine2':'address line 2',
                        'ContactName':'contact name',
                        'CountryId':'Brazil',
                        'StateOrProvinceId':1,
                        'DistrictId':1,
                        'City':'Some city',
                        'ZipCode':'11443-360',
                        'Phone':'+55(81)543-956124'
                    },
                }";
        }
        private User GetUser()
        {
            return new User
            {
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
    }
}
