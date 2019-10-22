using System;
using StormyCommerce.Module.Orders.Area.Models.Correios;
namespace StormyCommerce.Module.Orders.Area.Models
{
    public class DeliveryCalculationOptionResponse
    {
        public DeliveryCalculationOptionResponse(cServico calcModel)
        {
            DeliveryDeadline = Convert.ToDateTime(calcModel.PrazoEntrega);
            DeliveryMaxDate = Convert.ToDateTime(calcModel.DataMaxEntrega);
            HourOfDay = Convert.ToDateTime(calcModel.HoraMaxEntrega);
            Price = calcModel.Valor;
            Service = calcModel.Codigo.ToString();
        }
        public DateTime DeliveryDeadline { get; private set; }
        public DateTime DeliveryMaxDate { get; private set; }
        public DateTime HourOfDay { get; private set; }
        public string Price { get; private set; }
        public string Service { get; private set; }        
    }
}
