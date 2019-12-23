﻿
using System.Threading.Tasks;
using StormyCommerce.Core.Models;
using StormyCommerce.Core.Models.Dtos;
using StormyCommerce.Core.Models.Order;
using StormyCommerce.Core.Models.Order.Request;
using StormyCommerce.Core.Models.Payment.Request;
using StormyCommerce.Core.Models.Payment.Response;

namespace StormyCommerce.Core.Interfaces.Domain.Payments
{
    public interface IPaymentProcessor
    {        
        Task<ProcessPaymentResponse> ProcessBoletoPaymentRequestAsync(CheckoutBoletoRequest request,CustomerDto customerDto);
        Task<ProcessPaymentResponse> ProcessCreditCardPaymentAsync(CheckoutCreditCardRequest request, CustomerDto customerDto);
        //TODO:PostPaymentProcess Method
    }
}
