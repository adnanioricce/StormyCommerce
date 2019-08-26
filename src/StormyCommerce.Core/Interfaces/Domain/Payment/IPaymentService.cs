﻿using System.Threading.Tasks;
using StormyCommerce.Core.Models.Dtos.GatewayResponses.Payments;

namespace StormyCommerce.Core.Interfaces.Domain.Payment
{
    public interface IPaymentService
    {
        Task Checkout(BoletoViewModel paymentDto);               
    }
}
