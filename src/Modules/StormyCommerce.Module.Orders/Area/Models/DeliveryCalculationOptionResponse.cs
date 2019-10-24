using System;
using StormyCommerce.Module.Orders.Area.Models.Correios;
namespace StormyCommerce.Module.Orders.Area.Models
{
    public class DeliveryCalculationOptionResponse
    {
        public DeliveryCalculationOptionResponse(cServico calcModel)
        {
            DeliveryDeadline = DateTime.Now.AddDays(Convert.ToInt32(calcModel.PrazoEntrega));
            if(!String.IsNullOrEmpty(calcModel.DataMaxEntrega))
                DeliveryMaxDate = DateTime.Now.AddDays(Convert.ToInt32(calcModel.DataMaxEntrega));
            if(!(String.IsNullOrEmpty(calcModel.HoraMaxEntrega)))
                HourOfDay = DateTime.Now.AddDays(Convert.ToInt32(calcModel.HoraMaxEntrega));
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
