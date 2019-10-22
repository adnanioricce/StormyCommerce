using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Bogus;
using StormyCommerce.Module.PagarMe.Area.PagarMe.ViewModels;
using System.Collections.Generic;
using System;
using StormyCommerce.Core.Entities.Common;
using StormyCommerce.Module.PagarMe.Models;
using StormyCommerce.Core.Entities.Customer;

namespace StormyCommerce.Modules.IntegrationTest.Controllers
{
    public class PagarMeControllerTest : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _client;
        private readonly ITestOutputHelper _output;
        public PagarMeControllerTest(CustomWebApplicationFactory factory, ITestOutputHelper output)
        {
            _client = factory.WithWebHostBuilder(builder =>
            {
                builder.UseSolutionRelativeContentRoot("src/SimplCommerce.WebHost");
            }).CreateClient();
            _output = output;
        }
        [Theory]
        [InlineData(PaymentMethod.Boleto)]
        public async Task CheckoutOrder_SendTransactionVmWithGivenPaymentMethod_CreateNewOrderAndTransaction(PaymentMethod paymentMethod)
        {
            //Arrange                         
            var model = GetFakeTransactionVm(paymentMethod);
            //Act 
            var response = await _client.PostAsJsonAsync("charge/checkout",model);
            response.EnsureSuccessStatusCode();
            //Assert 
            Assert.True(response.IsSuccessStatusCode);
            Assert.Equal("application/json; charset=utf-8",response.Content.Headers.ContentType.ToString());
            
        }
        private TransactionVm GetFakeTransactionVm(PaymentMethod paymentMethod){
            return new TransactionVm{
                Amount = 2100,
                PaymentMethod = paymentMethod,
                Customer = new PagarMeCustomerVm{
                    ExternalId = "1234",
                    Name = "Rick",
                    Type = 0,
                    Country = "br",
                    Email = "rick@morty.com",
                    Documents = new List<Document>{
                        new Document{
                        Type = 0,
                        Number = "30621143049"
                        },
                        new Document{
                        Type = 1,
                        Number = "83134932000154"
                        }
                    },
                    PhoneNumbers = new List<string>
                    {
                        "+5511982738291",
                        "+5511829378291"
                    },
                    BirthDay = new DateTime(1991, 12, 12),
                },
                    Billing = new BillingVm{
                        Name = "Morty",
                        Address = new ShippingAddressModel
                        {
                            Country = "br",
                            State = "sp",
                            City = "Cotia",
                            District = "Rio Cotia",
                            Street = "Rua Matrix",
                            Number = "213",
                            PostalCode = "04250000"
                        }
                    },
                    Shipping = new ShippingVm{
                        Name = "Rick",
                        Fee = 100,
                        DeliveryDate = DateTime.UtcNow.AddDays(4).ToString("yyyy-MM-dd"),
                        Expedited = false,
                        Address = new ShippingAddressModel
                        {
                            Country = "br",
                            State = "sp",
                            City = "Cotia",
                            District = "Rio Cotia",
                            Street = "Rua Matrix",
                            Number = "213",
                            PostalCode = "04250000"
                        }
                    },
                    Items = new List<PagarMeItem>{
                        new PagarMeItem{
                            Id = "1",
                            Title = "Little Car",
                            Quantity = 1,
                            Tangible = true,
                            UnitPrice = 1000
                        },
                        new PagarMeItem
                        {
                            Id = "2",
                            Title = "Baby Crib",
                            Quantity = 1,
                            Tangible = true,
                            UnitPrice = 1000
                        }
                    }                    
                    };        
                }
        }
    
    }
