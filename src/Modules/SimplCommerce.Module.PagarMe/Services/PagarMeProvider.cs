using SimplCommerce.Module.Payments.Interfaces;
using SimplCommerce.Module.Payments.Models;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Orders.Models;
using System.Linq;
using Microsoft.Extensions.Options;
using SimplCommerce.Module.PagarMe.Settings;
using System.Text.Json;
using PagarMe;
using Microsoft.Extensions.Configuration;
using SimplCommerce.Module.Core.Models;
using SimplCommerce.Infrastructure.Models;
using System.Collections.Generic;
using System;

namespace SimplCommerce.Module.PagarMe.Services
{
    public class PagarMeProvider : IPaymentProvider
    {        
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Payment> _paymentRepository;
        private readonly IRepository<User> _userRepository;
        private readonly IRepositoryWithTypedId<PaymentProvider,string> _paymentProviderRepository;
        private readonly PagarMeWrapper _pagarMeService;
        
        public PagarMeProvider(IRepository<Order> orderRepository,
            IRepositoryWithTypedId<PaymentProvider,string> paymentProviderRepository,
            IRepository<User> userRepository,
            IRepository<Payment> paymentRepository,
            PagarMeWrapper pagarMeService            
            )
        {
            _orderRepository = orderRepository;
            _paymentProviderRepository = paymentProviderRepository;
            _userRepository = userRepository;
            _paymentRepository = paymentRepository;
            _pagarMeService = pagarMeService;                
        }
        public void ApplyProviderConfiguration()
        {
            var provider = _paymentProviderRepository.GetById("pagarme");
            var additionalSettings = JsonSerializer.Deserialize<PagarMeAdditionalSettings>(provider.AdditionalSettings);
            PagarMeService.DefaultApiKey = additionalSettings.ApiKey;
            PagarMeService.DefaultEncryptionKey = additionalSettings.DefaultEncryptionKey;
        }
        public void SetProviderConfiguration(PaymentProvider provider,PaymentProviderAdditionalSettings settings)
        {
            var additionalSettings = JsonSerializer.Serialize((PagarMeAdditionalSettings)settings);
            var _existentProvider = _paymentProviderRepository.GetById(provider.Id);
            if (!(_existentProvider is null))
            {
                _existentProvider.AdditionalSettings = additionalSettings;
                _paymentProviderRepository.Update(_existentProvider);
            } 
            else 
            {
                provider.AdditionalSettings = additionalSettings;
                _paymentProviderRepository.Add(provider);
            }
            _paymentProviderRepository.SaveChanges();            
        }

        public ProcessTransactionResponse ProcessTransaction(ProcessTransactionRequest request)
        {                        
            var transaction = _pagarMeService.Charge(request);            
            var payment = new Payment
            {
                Amount = request.TotalAmount,
                OrderId = request.OrderId,
                PaymentMethod = Enum.GetName(typeof(PaymentMethod), transaction.PaymentMethod).ToLower(),
                GatewayTransactionId = transaction.Id,
                Status = transaction.PaymentMethod == PaymentMethod.Boleto ? PaymentStatus.Pending : PaymentStatus.Succeeded,
                PaymentFee = transaction.Cost
            };
            _paymentRepository.Add(payment);
            _paymentRepository.SaveChanges();
            return new ProcessTransactionResponse
            {
                Message = "success",
                Success = true,
                PaymentId = payment.Id
            };
        }

        
    }
}
