using System;
using System.Collections.Generic;
using System.Text;
using StormyCommerce.Core.Models.Shipment.Response;
using StormyCommerce.Module.Orders.Area.Models.Correios;

namespace StormyCommerce.Module.Orders.Extensions
{
    public static class ShippingExtensions
    {
        public static DeliveryCalculationOptionResponse MapToDeliveryCalculationResponse(this cServico cServico)
        {
            var response = new DeliveryCalculationOptionResponse
            {
                DeliveryDeadline = DateTimeOffset.UtcNow.AddDays(Convert.ToInt32(cServico.PrazoEntrega)),                
                Price = cServico.Valor,
                Service = cServico.Codigo.ToString()
            };
            if (!String.IsNullOrEmpty(cServico.DataMaxEntrega))
            {
                response.DeliveryMaxDate = DateTimeOffset.UtcNow.AddDays(Convert.ToInt32(cServico.DataMaxEntrega));
            }
            if (!String.IsNullOrEmpty(cServico.HoraMaxEntrega))
            {
                response.HourOfDay = DateTime.UtcNow.AddDays(Convert.ToInt32(cServico.HoraMaxEntrega));
            }
            return response;
        }
    }
}
