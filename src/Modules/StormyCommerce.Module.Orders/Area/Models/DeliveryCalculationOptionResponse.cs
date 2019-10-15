using StormyCommerce.Module.Orders.Area.Models.Correios;
namespace StormyCommerce.Module.Orders.Area.Models
{
    public class DeliveryCalculationOptionResponse
    {
        public DeliveryCalculationOptionResponse(cServico calcModel)
        {
            DeliveryTime = calcModel.PrazoEntrega;
            DeliveryDate = calcModel.DataMaxEntrega;
            HourOfDay = calcModel.HoraMaxEntrega;
            Price = calcModel.Valor;
            Service = calcModel.Codigo;
        }
        public string DeliveryTime { get; private set; }
        public string DeliveryDate { get; private set; }
        public string HourOfDay { get; private set; }
        public string Price { get; private set; }
        public int Service { get; private set; }        

    }
}