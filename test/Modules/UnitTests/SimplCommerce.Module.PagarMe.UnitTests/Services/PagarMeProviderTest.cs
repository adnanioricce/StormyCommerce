using Microsoft.Extensions.Options;
using Moq;
using PagarMe;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Orders.Models;
using SimplCommerce.Module.PagarMe.Services;
using SimplCommerce.Module.PagarMe.Settings;
using SimplCommerce.Module.Payments.Models;
using SimplCommerce.Tests;
using System;
using System.Linq;
using Xunit;

namespace SimplCommerce.Module.PagarMe.UnitTests.Services
{
    public class PagarMeProviderTest
    {
        [Fact]
        public void ConfigureProvider_ReceivesPaymentProviderAndPaymentProviderAdditionalSettings_SetPaymentProviderEntryWithValuesGiven()
        {
            // Given
            var fakeProviderRepository = new FakeRepositoryWithTypedId<PaymentProvider, string>();
            var options = Options.Create<PagarMeAdditionalSettings>(new PagarMeAdditionalSettings());            
            var pagarMeProcessor = new PagarMeProvider(null,fakeProviderRepository,null,null,null);

            var settings = new PagarMeAdditionalSettings
            {
                ApiKey = Guid.NewGuid().ToString("N"),
                PaymentTaxAmount = 3.99m
            };
            PaymentProvider provider = new PaymentProvider("pagarme") { 
                //?I Should check if the url is working from PaymentProvider?
                ConfigureUrl = "some-url.com/to/payment-provider",   
                IsEnabled = true,
                Name = "PagarMe"                
            };            

            // When
            pagarMeProcessor.SetProviderConfiguration(provider,settings);

            // Then
            var result = fakeProviderRepository.GetById(provider.Id);
            var retrievedSettings = System.Text.Json.JsonSerializer.Deserialize<PagarMeAdditionalSettings>(result.AdditionalSettings);
            Assert.NotNull(result);
            Assert.Equal(settings.ApiKey, retrievedSettings.ApiKey);
            Assert.Equal(settings.PaymentTaxAmount, retrievedSettings.PaymentTaxAmount);
        }        
        [Fact]
        public void ProcessTransaction_Receives_ProcessTransactionRequest_WithPaymentMethodAsBoleto_ShouldCreateNew_PaymentOnDatabaseAndReturn_ProcessTransactionResponse()
        {
            var fakePaymentRepository = new FakeRepository<Payment>();
           
        }
        private PagarMeWrapper CreateFakeWrapper()
        {
            //TODO:implement method to return different mocks from different ProcessTransactionRequest objects
            var mockWrapper = new Mock<PagarMeWrapper>();
            return mockWrapper.Object;
        }
    }
}
